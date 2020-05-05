using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            var produto = new Produto();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
