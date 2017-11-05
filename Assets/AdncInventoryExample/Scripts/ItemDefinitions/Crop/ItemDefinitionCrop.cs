using System.Collections.Generic;
using Adnc.Utility;
using UnityEngine;

namespace Adnc.InventoryExample {
    [CreateAssetMenu(fileName = "Crop", menuName = MENU_PATH + "Crop")]
    public class ItemDefinitionCrop : ItemDefinitionBase {
        [Header("Crop Details")]

        [Tooltip("How can this object interact with the game world?")]
        [EnumFlags]
        [SerializeField]
        private ItemInteraction _interactions;

        public ItemInteraction Interactions {
            get { return _interactions; }
        }
        
        [Tooltip("Cost displayed to the user")]
        [SerializeField]
        private List<CurrencyCost> _cost = new List<CurrencyCost>();

        public virtual List<CurrencyCost> Cost {
            get { return _cost; }
        }
    }
}