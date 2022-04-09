using DemoSqlite.DataContext;
using DemoSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSqlite.Services
{
   public class ArtistaService
    {
        private readonly AppDbContext _context;

        public ArtistaService() => _context = App.GetContext();

        public List<Artista> Get()
        {
            return _context.Artistas.ToList();

        }

        public Artista GetByID(int ID)
        {

            //return _context.Artistas.Find(ID);
            return _context.Artistas.Where(x => x.ArtistaID == ID).FirstOrDefault();
        }

        public void Create(Artista artista)
        {
            _context.Artistas.Add(artista);
            _context.SaveChanges();
        }


        public void CreateRange(List<Artista> artistas)
        {                 
            _context.Artistas.AddRange(artistas);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            _context.Artistas.RemoveRange(_context.Artistas.ToList());
            _context.SaveChanges();
        }

        public void DeleteRange(List<Artista> artistas)
        {
            _context.Artistas.RemoveRange(artistas);
            _context.SaveChanges();
        }




    }
}
