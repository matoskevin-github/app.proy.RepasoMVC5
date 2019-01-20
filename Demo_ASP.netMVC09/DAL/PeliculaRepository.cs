using Demo_ASP.netMVC09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_ASP.netMVC09.DAL
{
    public class PeliculaRepository
    {

        public List<Pelicula> ObtenerPeliculas()
        {
            var lista = new List<Pelicula>();
            lista.Add(new Pelicula() {Titulo = "Pete's Dragon",EstaEnCartelera=true,Genero="Fantasia" });
            lista.Add(new Pelicula() { Titulo = "Mechanic: Resurrection", EstaEnCartelera = true, Genero = "Accion" });
            lista.Add(new Pelicula() { Titulo = "Deadpool", EstaEnCartelera = false, Genero = "Accion" });
            return lista;
        }

    }
}