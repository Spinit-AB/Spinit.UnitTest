using System.Collections.Generic;
using System.Linq;

namespace Spinit.UnitTest.Factories
{
    public class CollectionFactory
    {
        private static CollectionFactory _instance;

        private CollectionFactory() { }

        public static CollectionFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CollectionFactory();
                }

                return _instance;
            }
        }

        private List<object> Entities { get; set; } = new List<object>();

        public void Add<T>(T entity) => Entities.Add(entity);

        public void AddMany<T>(IEnumerable<T> entities) => Entities.AddRange(entities.Cast<object>());

        public IEnumerable<T> GetAll<T>() => Entities.OfType<T>().ToList();

        public void Remove<T>(T entity) => Entities.Remove(entity);

        public void Flush() => Entities = new List<object>();
    }
}