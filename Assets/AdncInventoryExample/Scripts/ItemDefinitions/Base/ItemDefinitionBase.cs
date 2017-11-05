using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adnc.InventoryExample {
    public abstract class ItemDefinitionBase : ScriptableObject {
        protected const string MENU_PATH = "ADNC/Inventory/Items/";

        [Tooltip("Name displayed to the user")]
        [SerializeField]
        private string _displayName;

        public virtual string DisplayName {
            get {
                if (string.IsNullOrEmpty(_displayName)) {
                    return "Untitled";
                }

                return _displayName;
            }
        }

        [Tooltip("Cost displayed to the user")]
        [SerializeField]
        private int _cost;

        public virtual int Cost {
            get { return _cost; }
        }

        [Tooltip("Description displayed to the user")]
        [TextArea]
        [SerializeField]
        private string _description;

        public virtual string Description {
            get {
                if (string.IsNullOrEmpty(_description)) {
                    return "No description";
                }

                return _description;
            }
        }
    }
}