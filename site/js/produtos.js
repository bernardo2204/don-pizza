// Cardápio do Don Pizza.
// Os ids e preços aqui são os MESMOS da tabela tblProdutos (banco/db_delivery.sql).
// Isso é importante: é o produto_id que vai no JSON do pedido pro C# achar o produto certo.
const produtos = [
  { id: 1, nome: "Pizza Margherita", descricao: "Molho de tomate, mussarela e manjericão", categoria: "Pizza Salgada", preco: 45.90, imagem: "margherita.jpg" },
  { id: 2, nome: "Pizza Calabresa", descricao: "Calabresa fatiada, cebola e mussarela", categoria: "Pizza Salgada", preco: 49.90, imagem: "calabresa.png" },
  { id: 3, nome: "Pizza Portuguesa", descricao: "Presunto, ovo, cebola, ervilha e mussarela", categoria: "Pizza Salgada", preco: 54.90, imagem: "portuguesa.jpg" },
  { id: 4, nome: "Pizza Frango com Catupiry", descricao: "Frango desfiado e catupiry", categoria: "Pizza Salgada", preco: 52.90, imagem: "frango_catupiry.jpg", posicao: "bottom" },
  { id: 5, nome: "Pizza Quatro Queijos", descricao: "Mussarela, provolone, parmesão e gorgonzola", categoria: "Pizza Salgada", preco: 56.90, imagem: "quatro_queijos.jpg" },
  { id: 6, nome: "Pizza Chocolate", descricao: "Chocolate ao leite e granulado", categoria: "Pizza Doce", preco: 44.90, imagem: "chocolate.jpg" },
  { id: 7, nome: "Pizza Romeu e Julieta", descricao: "Goiabada e mussarela", categoria: "Pizza Doce", preco: 42.90, imagem: "romeu_julieta.jpg" },
  { id: 8, nome: "Refrigerante 2L", descricao: "Coca-Cola 2 litros", categoria: "Bebida", preco: 14.00, imagem: "refrigerante.jpg" },
  { id: 9, nome: "Suco Natural 500ml", descricao: "Laranja", categoria: "Bebida", preco: 9.00, imagem: "suco.jpg" }
];

// Desenha os cards de produto na tela, filtrando pelo texto da busca
function mostrarProdutos(filtro) {
  const grid = document.getElementById("gridProdutos");
  if (!grid) return;

  const texto = (filtro || "").toLowerCase().trim();
  const lista = produtos.filter(p =>
    p.nome.toLowerCase().includes(texto) || p.categoria.toLowerCase().includes(texto)
  );

  grid.innerHTML = "";
  if (lista.length === 0) {
    grid.innerHTML = '<p style="text-align:center; grid-column:1/-1;">Nenhum produto encontrado.</p>';
    return;
  }

  lista.forEach(p => {
    const card = document.createElement("div");
    card.className = "card-produto";
    card.innerHTML = `
      <div class="foto-produto">
        <img src="../assets/produtos/${p.imagem}" alt="${p.nome}" loading="lazy" style="object-position:${p.posicao || "center"}">
        <span class="fita">${p.categoria}</span>
      </div>
      <div class="info-produto">
        <h3>${p.nome}</h3>
        <p>${p.descricao}</p>
        <span class="preco">R$ ${p.preco.toFixed(2).replace(".", ",")}</span>
        <button onclick="adicionarAoCarrinho(${p.id})">Adicionar ao carrinho</button>
      </div>
    `;
    grid.appendChild(card);
  });
}

document.addEventListener("DOMContentLoaded", function () {
  mostrarProdutos("");
  const campoBusca = document.getElementById("campoBusca");
  if (campoBusca) {
    campoBusca.addEventListener("input", function () {
      mostrarProdutos(campoBusca.value);
    });
  }
});
