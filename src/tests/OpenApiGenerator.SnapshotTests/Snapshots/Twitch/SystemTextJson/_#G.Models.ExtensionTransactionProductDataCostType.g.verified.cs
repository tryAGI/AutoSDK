//HintName: G.Models.ExtensionTransactionProductDataCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency exchanged. Possible values are:  
    ///   
    /// * bits
    /// </summary>
    public enum ExtensionTransactionProductDataCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Bits,
    }

    public static class ExtensionTransactionProductDataCostTypeExtensions
    {
        public static string ToValueString(this ExtensionTransactionProductDataCostType value)
        {
            return value switch
            {
                ExtensionTransactionProductDataCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionTransactionProductDataCostType ToEnum(string value)
        {
            return value switch
            {
                "bits" => ExtensionTransactionProductDataCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionTransactionProductDataCostType ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionTransactionProductDataCostType.Bits,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}