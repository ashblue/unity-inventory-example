using System.Collections.Generic;
using UnityEngine;

namespace Adnc.InventoryExample {
    [CreateAssetMenu(fileName = "Item", menuName = MENU_PATH + "Default")]
    public class ItemDefinition : ItemDefinitionBase {
        [Tooltip("Cost displayed to the user")]
        [SerializeField]
        private List<CurrencyCost> _cost = new List<CurrencyCost>();

        public virtual List<CurrencyCost> Cost {
            get { return _cost; }
        }
    }
}
