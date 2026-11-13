// Máscaras de CPF, telefone e CEP + trava de campo só-número.
// Usado na página de cadastro.

// Deixa só dígito no texto
function soNumero(texto) {
  return texto.replace(/\D/g, "");
}

// 000.000.000-00
function mascararCpf(valor) {
  valor = soNumero(valor).slice(0, 11);
  valor = valor.replace(/(\d{3})(\d)/, "$1.$2");
  valor = valor.replace(/(\d{3})(\d)/, "$1.$2");
  valor = valor.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
  return valor;
}

// (00) 00000-0000
function mascararTelefone(valor) {
  valor = soNumero(valor).slice(0, 11);
  valor = valor.replace(/(\d{2})(\d)/, "($1) $2");
  valor = valor.replace(/(\d{5})(\d{1,4})$/, "$1-$2");
  return valor;
}

// 00000-000
function mascararCep(valor) {
  valor = soNumero(valor).slice(0, 8);
  valor = valor.replace(/(\d{5})(\d{1,3})$/, "$1-$2");
  return valor;
}

// Liga a máscara certa em cada campo, pelo id
document.addEventListener("DOMContentLoaded", function () {
  const txtCpf = document.getElementById("txtCpf");
  const txtTelefone = document.getElementById("txtTelefone");
  const txtCep = document.getElementById("txtCep");

  if (txtCpf) txtCpf.addEventListener("input", () => txtCpf.value = mascararCpf(txtCpf.value));
  if (txtTelefone) txtTelefone.addEventListener("input", () => txtTelefone.value = mascararTelefone(txtTelefone.value));
  if (txtCep) txtCep.addEventListener("input", () => txtCep.value = mascararCep(txtCep.value));
});
