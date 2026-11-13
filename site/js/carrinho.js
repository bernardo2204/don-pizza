// Carrinho de compras - guardado no localStorage como lista de {produto_id, quantidade}

function getCarrinho() {
  const dados = localStorage.getItem("donpizza_carrinho");
  return dados ? JSON.parse(dados) : [];
}

function salvarCarrinho(carrinho) {
  localStorage.setItem("donpizza_carrinho", JSON.stringify(carrinho));
  atualizarContadorCarrinho();
}

function adicionarAoCarrinho(produtoId) {
  const carrinho = getCarrinho();
  const item = carrinho.find(i => i.produto_id === produtoId);
  if (item) {
    item.quantidade++;
  } else {
    carrinho.push({ produto_id: produtoId, quantidade: 1 });
  }
  salvarCarrinho(carrinho);
  alert("Adicionado ao carrinho!");
}

// Mostra quantos itens tem no carrinho (bolinha vermelha no ícone da navbar)
function atualizarContadorCarrinho() {
  const span = document.getElementById("qtdCarrinho");
  if (!span) return;
  const total = getCarrinho().reduce((soma, i) => soma + i.quantidade, 0);
  span.textContent = total;
  span.style.display = total > 0 ? "flex" : "none";
}

document.addEventListener("DOMContentLoaded", atualizarContadorCarrinho);

// ---------- Só usado na página carrinho.html ----------

function renderCarrinho() {
  const container = document.getElementById("listaCarrinho");
  if (!container) return;

  const carrinho = getCarrinho();
  if (carrinho.length === 0) {
    container.innerHTML = '<p class="carrinho-vazio">Seu carrinho está vazio.</p>';
    document.getElementById("resumoTotal").style.display = "none";
    return;
  }

  container.innerHTML = "";
  let total = 0;

  carrinho.forEach(item => {
    const produto = produtos.find(p => p.id === item.produto_id);
    if (!produto) return; // produto não existe mais no cardápio
    const subtotal = produto.preco * item.quantidade;
    total += subtotal;

    const div = document.createElement("div");
    div.className = "item-carrinho";
    div.innerHTML = `
      <div>
        <div class="nome">${produto.nome}</div>
        <div>R$ ${produto.preco.toFixed(2).replace(".", ",")} cada</div>
      </div>
      <div class="qtd-controle">
        <button onclick="alterarQuantidade(${produto.id}, -1)">-</button>
        &nbsp;${item.quantidade}&nbsp;
        <button onclick="alterarQuantidade(${produto.id}, 1)">+</button>
        <span class="remover" onclick="removerItem(${produto.id})">remover</span>
      </div>
    `;
    container.appendChild(div);
  });

  document.getElementById("resumoTotal").style.display = "flex";
  document.getElementById("valorTotal").textContent = "R$ " + total.toFixed(2).replace(".", ",");
}

function alterarQuantidade(produtoId, delta) {
  const carrinho = getCarrinho();
  const item = carrinho.find(i => i.produto_id === produtoId);
  if (!item) return;
  item.quantidade += delta;
  if (item.quantidade <= 0) {
    removerItem(produtoId);
    return;
  }
  salvarCarrinho(carrinho);
  renderCarrinho();
}

function removerItem(produtoId) {
  const carrinho = getCarrinho().filter(i => i.produto_id !== produtoId);
  salvarCarrinho(carrinho);
  renderCarrinho();
}

// Monta o pedido no formato combinado com o David e baixa o pedidos.json
function finalizarPedido() {
  const emailCliente = localStorage.getItem("donpizza_cliente_logado");
  if (!emailCliente) {
    alert("Faça login antes de finalizar o pedido.");
    window.location.href = "login.html";
    return;
  }

  const carrinho = getCarrinho();
  if (carrinho.length === 0) {
    alert("Seu carrinho está vazio.");
    return;
  }

  const clientes = JSON.parse(localStorage.getItem("donpizza_clientes") || "[]");
  const cliente = clientes.find(c => c.email === emailCliente);
  const endereco = cliente ? cliente.endereco : document.getElementById("txtEndereco").value;
  const formaPagamento = document.getElementById("cmbPagamento").value;

  const itens = carrinho.map(item => {
    const produto = produtos.find(p => p.id === item.produto_id);
    return {
      produto_id: produto.id,
      quantidade: item.quantidade,
      preco_unitario: produto.preco
    };
  });

  const valorTotal = itens.reduce((soma, i) => soma + i.quantidade * i.preco_unitario, 0);

  // Data no formato "yyyy-MM-dd HH:mm:ss", igual o C# espera
  const agora = new Date();
  const pad = n => String(n).padStart(2, "0");
  const dataPedido = `${agora.getFullYear()}-${pad(agora.getMonth() + 1)}-${pad(agora.getDate())} ${pad(agora.getHours())}:${pad(agora.getMinutes())}:${pad(agora.getSeconds())}`;

  const pedido = [{
    cliente_email: emailCliente,
    data_pedido: dataPedido,
    forma_pagamento: formaPagamento,
    endereco_entrega: endereco,
    valor_total: Number(valorTotal.toFixed(2)),
    itens: itens
  }];

  // Baixa o arquivo pedidos.json no computador do cliente
  const blob = new Blob([JSON.stringify(pedido, null, 2)], { type: "application/json" });
  const link = document.createElement("a");
  link.href = URL.createObjectURL(blob);
  link.download = "pedidos.json";
  link.click();

  // Cópia local pra "Meus Pedidos" - não reflete status real do banco, só o que foi enviado
  const historico = JSON.parse(localStorage.getItem("donpizza_pedidos") || "[]");
  historico.push(pedido[0]);
  localStorage.setItem("donpizza_pedidos", JSON.stringify(historico));

  salvarCarrinho([]);
  alert("Pedido gerado! O arquivo pedidos.json foi baixado - leve ele até a gestão da pizzaria.");
  renderCarrinho();
}

document.addEventListener("DOMContentLoaded", renderCarrinho);
