//HintName: G.Models.ExtensionTransactionProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of transaction. Possible values are:  
    ///   
    /// * BITS\_IN\_EXTENSION
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionTransactionProductType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BITS_IN_EXTENSION")]
        BITSINEXTENSION,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionTransactionProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtensionTransactionProductType value)
        {
            return value switch
            {
                ExtensionTransactionProductType.BITSINEXTENSION => "BITS_IN_EXTENSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionTransactionProductType ToEnum(string value)
        {
            return value switch
            {
                "BITS_IN_EXTENSION" => ExtensionTransactionProductType.BITSINEXTENSION,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}