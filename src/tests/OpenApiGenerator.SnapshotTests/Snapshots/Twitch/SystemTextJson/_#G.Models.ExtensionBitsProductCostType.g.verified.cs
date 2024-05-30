//HintName: G.Models.ExtensionBitsProductCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency. Possible values are:  
    ///   
    /// * bits
    /// </summary>
    public enum ExtensionBitsProductCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Bits,
    }

    public static class ExtensionBitsProductCostTypeExtensions
    {
        public static string ToValueString(this ExtensionBitsProductCostType value)
        {
            return value switch
            {
                ExtensionBitsProductCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionBitsProductCostType ToEnum(string value)
        {
            return value switch
            {
                "bits" => ExtensionBitsProductCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionBitsProductCostType ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionBitsProductCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}