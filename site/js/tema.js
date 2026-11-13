// Modo claro/escuro - guarda a escolha no localStorage pra lembrar na próxima visita
function aplicarTema(tema) {
  document.documentElement.setAttribute("data-theme", tema);
  localStorage.setItem("donpizza_tema", tema);
}

function alternarTema() {
  const atual = localStorage.getItem("donpizza_tema") || "dark";
  aplicarTema(atual === "dark" ? "light" : "dark");
}

document.addEventListener("DOMContentLoaded", function () {
  aplicarTema(localStorage.getItem("donpizza_tema") || "dark");
  const btn = document.getElementById("btnTema");
  if (btn) btn.addEventListener("click", alternarTema);
});
