namespace Adnc.InventoryExample {
    [System.Flags]
    public enum ItemInteraction {
        AnimalEdible = 1,
        PlayerEdible = 2,
        HumanEdible = 4
    }

    /// <summary>
    /// @SRC https://stackoverflow.com/questions/5985661/methods-inside-enum-in-c-sharp
    /// @SRC https://stackoverflow.com/questions/204711/how-should-i-check-if-a-flag-is-set-in-a-flags-enum
    /// </summary>
    static class ItemInteractionMethods {
        public static bool HasFlagCheck (this ItemInteraction interaction, ItemInteraction flag) {
            return flag == (interaction & flag);
        }
    }
}