using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class DbCache
    {
        private readonly Dictionary<string, object> cache;
        private readonly TimeSpan defaultExpiry;

        public DbCache(TimeSpan defaultExpiry)
        {
            this.cache = new Dictionary<string, object>();
            this.defaultExpiry = defaultExpiry;
        }

        public T Get<T>(string key)
        {
            if (cache.ContainsKey(key) && IsValid(key))
            {
                return (T)cache[key];
            }
            return default(T);
        }

        public void Set<T>(string key, T value)
        {
            cache[key] = value;
            SetExpiry(key);
        }

        private bool IsValid(string key)
        {
            // Implement logic to check if cached data is still valid based on expiry time
            return cache.ContainsKey(key) && DateTime.UtcNow < (DateTime)cache[key + "_expiry"];
        }

        private void SetExpiry(string key)
        {
            cache[key + "_expiry"] = DateTime.UtcNow.Add(defaultExpiry);
        }
    }
}