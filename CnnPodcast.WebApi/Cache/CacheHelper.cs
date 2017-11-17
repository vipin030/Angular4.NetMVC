﻿using System;
using System.Web;

namespace CnnPodcast.WebApi.Cache
{
    public static class CacheHelper<T>
    {
        /// <summary>
        /// Simple cache helper.
        /// </summary>
        /// <param name="key">The cache key used to reference the item.</param>
        /// <param name="function">The underlying method that referes to the object to be stored in the cache.</param>
        /// <returns>The item.</returns>
        public static T Get(string key, Func<T> function)
        {
            var obj = (T)HttpContext.Current.Cache[key];

            if (obj == null)
            {
                obj = function.Invoke();

                // In case obj variable is null, set the default operator
                if (obj == null)
                {
                    return default(T);
                }

                HttpContext.Current.Cache.Add(key, obj, null, DateTime.Now.AddMinutes(3), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Normal, null);
            }

            return obj;
        }
    }
}