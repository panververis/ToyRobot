namespace Common
{
    /// <summary>
    /// Public static class holding the Tech Test's initial parameters (table width and length, for example)
    /// </summary>
    public static class InitialParams
    {
        /// <summary>
        /// Denotes the range of the X positions that Speedy can move into (so the allowed positions range from "0" to "TableWidth-1")
        /// </summary>
        public static int TableWidth => 5;

        /// <summary>
        /// Denotes the range of the Y positions that Speedy can move into (so the allowed positions range from "0" to "TableLength-1")
        /// </summary>
        public static int TableLength => 5;
    }
}
