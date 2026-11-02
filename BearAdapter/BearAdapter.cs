using System;

namespace BearAdapter
{
    public class BearAdapter : IDog
    {
        private readonly IBear bear;

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
        
        public void Bark()
        {
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }
    }
}