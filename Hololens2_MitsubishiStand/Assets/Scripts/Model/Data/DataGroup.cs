using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Model.Data
{
    public class DataGroup<TDataType, TItemType>
        where TItemType : MonoBehaviour, IItemRenderer<TDataType>
    {
        protected readonly List<TItemType> CreatedItems = new List<TItemType>();
        private readonly TItemType _prefab;
        private readonly Transform _container;

        public DataGroup(TItemType prefab, Transform container)
        {
            _prefab = prefab;
            _container = container;
        }

        public virtual void SetData(IList<TDataType> data)
        {
            // Create required items
            for (int i = CreatedItems.Count; i < data.Count; i++)
            {
                var item = Object.Instantiate(_prefab, _container);
                CreatedItems.Add(item);
            }
            // Update data & activate
            for (int i = 0; i < data.Count; i++)
            {
                CreatedItems[i].SetData(data[i], i);
                CreatedItems[i].gameObject.SetActive(true);
            }
            //Hide unused items
            for (int i = data.Count; i < CreatedItems.Count; i++)
            {
                CreatedItems[i].gameObject.SetActive(false);
            }
        }
    }

    public interface IItemRenderer<in TDataType>
    {
        void SetData(TDataType data, int index);
    }
}
