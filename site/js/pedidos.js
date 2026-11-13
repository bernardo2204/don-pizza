function formatarData(dataPedido) {
  const [data, hora] = dataPedido.split(" ");
  const [ano, mes, dia] = data.split("-");
  return `${dia}/${mes}/${ano} às ${hora.slice(0, 5)}`;
}

function renderPedidos() {
  const container = document.getElementById("listaPedidos");
  if (!container) return;

  const emailLogado = exigirLogin();
  if (!emailLogado) return;

  const todos = JSON.parse(localStorage.getItem("donpizza_pedidos") || "[]");
  const meusPedidos = todos
    .filter(p => p.cliente_email === emailLogado)
    .sort((a, b) => b.data_pedido.localeCompare(a.data_pedido));

  if (meusPedidos.length === 0) {
    container.innerHTML = '<p class="pedidos-vazio">Você ainda não fez nenhum pedido. <a href="index.html">Ver cardápio</a></p>';
    return;
  }

  container.innerHTML = "";
  meusPedidos.forEach((pedido, indice) => {
    const linhasItens = pedido.itens.map(item => {
      const produto = produtos.find(p => p.id === item.produto_id);
      const nome = produto ? produto.nome : `Produto #${item.produto_id}`;
      return `<div class="linha-item"><span>${item.quantidade}x ${nome}</span><span>R$ ${(item.quantidade * item.preco_unitario).toFixed(2).replace(".", ",")}</span></div>`;
    }).join("");

    const card = document.createElement("div");
    card.className = "pedido-card";
    card.innerHTML = `
      <div class="topo">
        <span class="numero">Pedido #${meusPedidos.length - indice}</span>
        <span class="data">${formatarData(pedido.data_pedido)}</span>
      </div>
      ${linhasItens}
      <div class="rodape">
        <div>
          <div>${pedido.forma_pagamento}, ${pedido.endereco_entrega}</div>
          <span class="status-badge">Recebido</span>
        </div>
        <span class="total">R$ ${pedido.valor_total.toFixed(2).replace(".", ",")}</span>
      </div>
    `;
    container.appendChild(card);
  });
}

document.addEventListener("DOMContentLoaded", renderPedidos);
