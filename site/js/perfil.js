function preencherPerfil() {
  const emailLogado = exigirLogin();
  if (!emailLogado) return;

  const cliente = getClientes().find(c => c.email === emailLogado);
  if (!cliente) return;

  document.getElementById("avatarInicial").textContent = cliente.nome.trim()[0].toUpperCase();
  document.getElementById("txtNome").value = cliente.nome;
  document.getElementById("txtCpf").value = cliente.cpf;
  document.getElementById("txtTelefone").value = cliente.telefone;
  document.getElementById("txtEmail").value = cliente.email;
  document.getElementById("txtCep").value = cliente.cep;
  document.getElementById("txtEndereco").value = cliente.endereco;
}

function salvarPerfil(evento) {
  evento.preventDefault();

  const emailLogado = exigirLogin();
  if (!emailLogado) return;

  const clientes = getClientes();
  const cliente = clientes.find(c => c.email === emailLogado);
  if (!cliente) return;

  cliente.nome = document.getElementById("txtNome").value.trim();
  cliente.cpf = document.getElementById("txtCpf").value;
  cliente.telefone = document.getElementById("txtTelefone").value;
  cliente.cep = document.getElementById("txtCep").value;
  cliente.endereco = document.getElementById("txtEndereco").value.trim();

  salvarClientes(clientes);
  document.getElementById("avatarInicial").textContent = cliente.nome[0].toUpperCase();
  alert("Dados atualizados!");
}

document.addEventListener("DOMContentLoaded", preencherPerfil);
