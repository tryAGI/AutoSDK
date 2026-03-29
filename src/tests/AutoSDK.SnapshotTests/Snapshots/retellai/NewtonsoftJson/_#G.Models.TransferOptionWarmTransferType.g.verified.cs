//HintName: G.Models.TransferOptionWarmTransferType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the transfer.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferOptionWarmTransferType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warm_transfer")]
        WarmTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionWarmTransferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionWarmTransferType value)
        {
            return value switch
            {
                TransferOptionWarmTransferType.WarmTransfer => "warm_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionWarmTransferType? ToEnum(string value)
        {
            return value switch
            {
                "warm_transfer" => TransferOptionWarmTransferType.WarmTransfer,
                _ => null,
            };
        }
    }
}