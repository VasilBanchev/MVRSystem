using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CardManager : IContext<Card, string>
    {
        private CardContext _CardContext;
        public CardManager(MVRSystemDBContext context)
        {
            this._CardContext = new CardContext(context);
        }
        public void Create(Card item)
        {
            try
            {
                _CardContext.Create(item);
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
                _CardContext.Delete(key);
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
                return _CardContext.Read(key);
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
                return _CardContext.ReadAll().ToList();
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
                _CardContext.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}

