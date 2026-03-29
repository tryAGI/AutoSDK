//HintName: G.Models.TransferFailedEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "Transfer failed" for transfer failed edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferFailedEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Transfer failed")]
        TransferFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferFailedEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferFailedEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                TransferFailedEdgeVariant2TransitionConditionPrompt.TransferFailed => "Transfer failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferFailedEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Transfer failed" => TransferFailedEdgeVariant2TransitionConditionPrompt.TransferFailed,
                _ => null,
            };
        }
    }
}