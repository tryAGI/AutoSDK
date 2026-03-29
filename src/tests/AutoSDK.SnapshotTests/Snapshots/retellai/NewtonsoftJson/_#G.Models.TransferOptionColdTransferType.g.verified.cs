//HintName: G.Models.TransferOptionColdTransferType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the transfer.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferOptionColdTransferType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cold_transfer")]
        ColdTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionColdTransferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionColdTransferType value)
        {
            return value switch
            {
                TransferOptionColdTransferType.ColdTransfer => "cold_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionColdTransferType? ToEnum(string value)
        {
            return value switch
            {
                "cold_transfer" => TransferOptionColdTransferType.ColdTransfer,
                _ => null,
            };
        }
    }
}