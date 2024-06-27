﻿using AutoMapper;
using BlazingPizza.Api.Entites;
using BlazingPizzaria.Models.DTOs;

namespace BlazingPizza.Api.Profiles
{
    public class ProdutosProfile : Profile
    {
        public ProdutosProfile()
        {
                CreateMap<Atributos, AtributosDtos>().ReverseMap();
                CreateMap<Avaliacao, AvaliacaoDtos>().ReverseMap();
                CreateMap<CarrinhoDeCompra, CarrinhoDeCompraDtos>().ReverseMap();
                CreateMap<CarrinhoDeItems, CarrinhoDeItemsDtos>().ReverseMap();
                CreateMap<Categoria, CategoriasDtos>().ReverseMap();
                CreateMap<Dimensoes, DimensoesDtos>().ReverseMap();
                CreateMap<Imagem, ImagemDtos>().ReverseMap();
                CreateMap<Produto, ProdutoDtos>().ReverseMap();
                CreateMap<Revisao, RevisaoDtos>().ReverseMap();
                CreateMap<Usuario, UsuariosDtos>().ReverseMap();
        }
    }
}
