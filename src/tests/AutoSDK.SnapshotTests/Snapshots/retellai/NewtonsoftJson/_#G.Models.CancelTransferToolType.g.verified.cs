//HintName: G.Models.CancelTransferToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CancelTransferToolType
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
    public static class CancelTransferToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelTransferToolType value)
        {
            return value switch
            {
                CancelTransferToolType.CancelTransfer => "cancel_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelTransferToolType? ToEnum(string value)
        {
            return value switch
            {
                "cancel_transfer" => CancelTransferToolType.CancelTransfer,
                _ => null,
            };
        }
    }
}