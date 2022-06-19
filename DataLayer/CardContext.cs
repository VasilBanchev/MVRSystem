using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;

namespace DataLayer
{
    public class CardContext : IDB<Card, string>
    {
        private MVRSystemDBContext _context;

        public CardContext(MVRSystemDBContext context)
        {
            _context = context;
        }

        public void Create(Card item)
        {
            try
            {
                _context.Cards.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                Card cardFromDB = Read(key);
                _context.Remove(cardFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Card Read(string key)
        {
            try
            {
                return _context.Cards.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Card> ReadAll()
        {
            try
            {
                return _context.Cards.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Card item)
        {
            try
            {
                Card cardFromDB = Read(item.Id);

                _context.Entry(cardFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
