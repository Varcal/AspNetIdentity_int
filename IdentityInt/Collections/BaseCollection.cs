using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IdentityInt.Collections
{
    public abstract class BaseCollection<TEntity>: ICollection<TEntity> where TEntity : class
    {
        protected readonly ICollection<TEntity> Collection;

        protected BaseCollection()
        {
            Collection = new List<TEntity>();
        }

        protected BaseCollection(IList<TEntity> list)
        {
            Collection = new Collection<TEntity>(list);
        }

        public virtual void Add(TEntity item)
        {
            Collection.Add(item);
        }

        public void AddRange(IEnumerable<TEntity> listOfEntities)
        {
            if (listOfEntities == null) return;

            foreach (var item in listOfEntities)
            {
                Add(item);
            }
        }

        public virtual void Clear()
        {
            Collection.Clear();
        }

        public virtual bool Contains(TEntity item)
        {
            return Collection.Contains(item);
        }

        public virtual void CopyTo(TEntity[] array, int arrayIndex)
        {
            Collection.CopyTo(array, arrayIndex);
        }

        public virtual int Count => Collection.Count;

        public virtual bool IsReadOnly => Collection.IsReadOnly;

        public virtual bool Remove(TEntity item)
        {
            return Collection.Remove(item);
        }

        public virtual IEnumerator<TEntity> GetEnumerator()
        {
            return Collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}