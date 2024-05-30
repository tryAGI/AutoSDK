//HintName: G.Models.ExtensionTransactionProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of transaction. Possible values are:  
    ///   
    /// * BITS\_IN\_EXTENSION
    /// </summary>
    public enum ExtensionTransactionProductType
    {
        /// <summary>
        /// 
        /// </summary>
        BITSINEXTENSION,
    }

    public static class ExtensionTransactionProductTypeExtensions
    {
        public static string ToValueString(this ExtensionTransactionProductType value)
        {
            return value switch
            {
                ExtensionTransactionProductType.BITSINEXTENSION => "BITS_IN_EXTENSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionTransactionProductType ToEnum(string value)
        {
            return value switch
            {
                "BITS_IN_EXTENSION" => ExtensionTransactionProductType.BITSINEXTENSION,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionTransactionProductType ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionTransactionProductType.BITSINEXTENSION,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}