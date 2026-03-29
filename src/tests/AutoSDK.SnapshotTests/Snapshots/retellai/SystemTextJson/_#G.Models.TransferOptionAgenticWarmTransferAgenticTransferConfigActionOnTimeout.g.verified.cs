//HintName: G.Models.TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action to take when the transfer agent times out without making a decision. Defaults to cancel_transfer.<br/>
    /// Default Value: cancel_transfer
    /// </summary>
    public enum TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout
    {
        /// <summary>
        /// 
        /// </summary>
        BridgeTransfer,
        /// <summary>
        /// 
        /// </summary>
        CancelTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout value)
        {
            return value switch
            {
                TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout.BridgeTransfer => "bridge_transfer",
                TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout.CancelTransfer => "cancel_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout? ToEnum(string value)
        {
            return value switch
            {
                "bridge_transfer" => TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout.BridgeTransfer,
                "cancel_transfer" => TransferOptionAgenticWarmTransferAgenticTransferConfigActionOnTimeout.CancelTransfer,
                _ => null,
            };
        }
    }
}