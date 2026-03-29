//HintName: G.Models.TransferCancelToolUserEditableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "transferCancel" for Transfer Cancel tool. This tool can only be used during warm-transfer-experimental by the transfer assistant to cancel an ongoing transfer and return the call back to the original assistant when the transfer cannot be completed.
    /// </summary>
    public enum TransferCancelToolUserEditableType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferCancelToolUserEditableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferCancelToolUserEditableType value)
        {
            return value switch
            {
                TransferCancelToolUserEditableType.TransferCancel => "transferCancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferCancelToolUserEditableType? ToEnum(string value)
        {
            return value switch
            {
                "transferCancel" => TransferCancelToolUserEditableType.TransferCancel,
                _ => null,
            };
        }
    }
}