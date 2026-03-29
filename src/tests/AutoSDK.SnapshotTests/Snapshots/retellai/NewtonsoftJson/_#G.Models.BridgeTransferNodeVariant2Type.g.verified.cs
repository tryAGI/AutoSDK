//HintName: G.Models.BridgeTransferNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node - initiates a warm transfer by bridging the call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BridgeTransferNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bridge_transfer")]
        BridgeTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BridgeTransferNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeTransferNodeVariant2Type value)
        {
            return value switch
            {
                BridgeTransferNodeVariant2Type.BridgeTransfer => "bridge_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeTransferNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bridge_transfer" => BridgeTransferNodeVariant2Type.BridgeTransfer,
                _ => null,
            };
        }
    }
}