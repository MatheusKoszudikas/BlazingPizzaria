﻿// <auto-generated />
using System;
using BlazingPizza.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingPizza.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazingPizza.Api.Entites.Atributos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Atributos");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Media")
                        .HasColumnType("float");

                    b.Property<int>("NumeroDeAvaliacoes")
                        .HasColumnType("int");

                    b.Property<int>("RevisaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RevisaoId");

                    b.ToTable("Avaliacaos");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.CarrinhoDeCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CarrinhoDeCompra");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.CarrinhoDeItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarrinhoDeCompraId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoDeCompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CarrinhoDeItems");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Dimensoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<double>("Profundidade")
                        .HasColumnType("float");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dimensoes");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Disponibilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEstimadaDeEntrega")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstaDisponivel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Disponibilidades");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TextoAlternativo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtributosId")
                        .HasColumnType("int");

                    b.Property<int>("AvaliacaoId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DimensoesId")
                        .HasColumnType("int");

                    b.Property<int>("DisponibilidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ImagemId")
                        .HasColumnType("int");

                    b.Property<string>("LocalizacaoEstoque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Moeda")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("QuantidadeEmEstoque")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AtributosId");

                    b.HasIndex("AvaliacaoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("DimensoesId");

                    b.HasIndex("DisponibilidadeId");

                    b.HasIndex("ImagemId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Revisao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Revisaos");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Avaliacao", b =>
                {
                    b.HasOne("BlazingPizza.Api.Entites.Revisao", "Revisao")
                        .WithMany()
                        .HasForeignKey("RevisaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Revisao");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.CarrinhoDeCompra", b =>
                {
                    b.HasOne("BlazingPizza.Api.Entites.Usuario", "Usuario")
                        .WithMany("CarrinhosDeCompra")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.CarrinhoDeItems", b =>
                {
                    b.HasOne("BlazingPizza.Api.Entites.CarrinhoDeCompra", "CarrinhoDeCompra")
                        .WithMany("Items")
                        .HasForeignKey("CarrinhoDeCompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarrinhoDeCompra");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Produto", b =>
                {
                    b.HasOne("BlazingPizza.Api.Entites.Atributos", "Atributos")
                        .WithMany()
                        .HasForeignKey("AtributosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Avaliacao", "Avaliacao")
                        .WithMany()
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Categoria", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Dimensoes", "Dimensoes")
                        .WithMany()
                        .HasForeignKey("DimensoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Disponibilidade", "Disponibilidades")
                        .WithMany()
                        .HasForeignKey("DisponibilidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Api.Entites.Imagem", "Imagem")
                        .WithMany()
                        .HasForeignKey("ImagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atributos");

                    b.Navigation("Avaliacao");

                    b.Navigation("Categorias");

                    b.Navigation("Dimensoes");

                    b.Navigation("Disponibilidades");

                    b.Navigation("Imagem");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.CarrinhoDeCompra", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("BlazingPizza.Api.Entites.Usuario", b =>
                {
                    b.Navigation("CarrinhosDeCompra");
                });
#pragma warning restore 612, 618
        }
    }
}
