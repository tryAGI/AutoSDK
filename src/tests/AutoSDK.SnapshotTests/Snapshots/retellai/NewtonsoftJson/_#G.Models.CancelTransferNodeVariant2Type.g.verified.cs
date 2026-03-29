//HintName: G.Models.CancelTransferNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node - cancels the warm transfer and ends the transfer agent call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CancelTransferNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancel_transfer")]
        CancelTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelTransferNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelTransferNodeVariant2Type value)
        {
            return value switch
            {
                CancelTransferNodeVariant2Type.CancelTransfer => "cancel_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelTransferNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cancel_transfer" => CancelTransferNodeVariant2Type.CancelTransfer,
                _ => null,
            };
        }
    }
}