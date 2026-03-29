//HintName: G.Models.TransferOptionAgenticWarmTransferType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the transfer.
    /// </summary>
    public enum TransferOptionAgenticWarmTransferType
    {
        /// <summary>
        /// 
        /// </summary>
        AgenticWarmTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionAgenticWarmTransferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionAgenticWarmTransferType value)
        {
            return value switch
            {
                TransferOptionAgenticWarmTransferType.AgenticWarmTransfer => "agentic_warm_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionAgenticWarmTransferType? ToEnum(string value)
        {
            return value switch
            {
                "agentic_warm_transfer" => TransferOptionAgenticWarmTransferType.AgenticWarmTransfer,
                _ => null,
            };
        }
    }
}