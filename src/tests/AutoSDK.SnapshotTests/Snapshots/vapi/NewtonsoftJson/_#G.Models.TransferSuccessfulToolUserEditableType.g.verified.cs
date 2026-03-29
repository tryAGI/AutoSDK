//HintName: G.Models.TransferSuccessfulToolUserEditableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "transferSuccessful" for Transfer Successful tool. This tool can only be used during warm-transfer-experimental by the transfer assistant to confirm that the transfer should proceed and finalize the handoff to the destination.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferSuccessfulToolUserEditableType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transferSuccessful")]
        TransferSuccessful,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferSuccessfulToolUserEditableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferSuccessfulToolUserEditableType value)
        {
            return value switch
            {
                TransferSuccessfulToolUserEditableType.TransferSuccessful => "transferSuccessful",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferSuccessfulToolUserEditableType? ToEnum(string value)
        {
            return value switch
            {
                "transferSuccessful" => TransferSuccessfulToolUserEditableType.TransferSuccessful,
                _ => null,
            };
        }
    }
}