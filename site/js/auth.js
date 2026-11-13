// Login e cadastro de cliente - guardado no localStorage (sem backend ainda).
// Isso é só pro protótipo do site funcionar sozinho; no projeto de verdade
// o cadastro de cliente também vai pro banco quando o pedido for importado.

function getClientes() {
  return JSON.parse(localStorage.getItem("donpizza_clientes") || "[]");
}

function salvarClientes(lista) {
  localStorage.setItem("donpizza_clientes", JSON.stringify(lista));
}

// ---------- Cadastro ----------
function cadastrarCliente(evento) {
  evento.preventDefault();

  const nome = document.getElementById("txtNome").value.trim();
  const cpf = document.getElementById("txtCpf").value;
  const telefone = document.getElementById("txtTelefone").value;
  const email = document.getElementById("txtEmail").value.trim().toLowerCase();
  const senha = document.getElementById("txtSenha").value;
  const cep = document.getElementById("txtCep").value;
  const endereco = document.getElementById("txtEndereco").value.trim();

  const erro = document.getElementById("msgErro");
  const clientes = getClientes();

  if (clientes.some(c => c.email === email)) {
    erro.textContent = "Já existe cadastro com esse email.";
    return;
  }

  clientes.push({ nome, cpf, telefone, email, senha, cep, endereco });
  salvarClientes(clientes);

  localStorage.setItem("donpizza_cliente_logado", email);
  alert("Cadastro feito com sucesso!");
  window.location.href = "index.html";
}

// ---------- Login ----------
function fazerLogin(evento) {
  evento.preventDefault();

  const email = document.getElementById("txtEmail").value.trim().toLowerCase();
  const senha = document.getElementById("txtSenha").value;
  const erro = document.getElementById("msgErro");

  const cliente = getClientes().find(c => c.email === email && c.senha === senha);
  if (!cliente) {
    erro.textContent = "Email ou senha incorretos.";
    return;
  }

  localStorage.setItem("donpizza_cliente_logado", email);
  window.location.href = "index.html";
}

function sairLogin() {
  localStorage.removeItem("donpizza_cliente_logado");
  window.location.href = "index.html";
}

// Manda pro login quem tentar abrir uma página que exige conta (perfil, pedidos)
function exigirLogin() {
  const emailLogado = localStorage.getItem("donpizza_cliente_logado");
  if (!emailLogado) {
    window.location.href = "login.html";
    return null;
  }
  return emailLogado;
}

// Troca os links "Entrar/Cadastrar" da navbar por "Pedidos / Perfil / Olá, nome / Sair" quando logado
document.addEventListener("DOMContentLoaded", function () {
  const areaConta = document.getElementById("areaConta");
  if (!areaConta) return;

  const emailLogado = localStorage.getItem("donpizza_cliente_logado");
  if (emailLogado) {
    const cliente = getClientes().find(c => c.email === emailLogado);
    const nome = cliente ? cliente.nome.split(" ")[0] : emailLogado;
    areaConta.innerHTML = `
      <a href="pedidos.html">Pedidos</a>
      <a href="perfil.html">Perfil</a>
      <span class="saudacao">Olá, ${nome}</span>
      <button onclick="sairLogin()">Sair</button>
    `;
  }
});
