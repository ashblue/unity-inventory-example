using System.Collections.Generic;
using UnityEngine;

namespace Adnc.InventoryExample {
    public abstract class ItemDefinitionPurchaseBase : ItemDefinitionBase {
        [Tooltip("Cost displayed to the user")]
        [SerializeField]
        private List<CurrencyCost> _cost = new List<CurrencyCost>();

        public virtual List<CurrencyCost> Cost {
            get { return _cost; }
        }

        [Tooltip("Amount given back when sold by the player")]
        [SerializeField]
        private List<CurrencyCost> _sale = new List<CurrencyCost>();

        public virtual List<CurrencyCost> Sale {
            get { return _sale; }
        }
    }
}