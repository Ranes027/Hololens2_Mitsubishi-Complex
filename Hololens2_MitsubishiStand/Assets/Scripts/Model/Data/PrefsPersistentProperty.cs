using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Model.Data
{
    public abstract class PrefsPersistentProperty<TPropertyType> : PersistentProperty<TPropertyType>
    {
        protected string Key;

        protected PrefsPersistentProperty(TPropertyType defaultValue, string key) : base(defaultValue)
        {
            Key = key;
        }
    }

}
