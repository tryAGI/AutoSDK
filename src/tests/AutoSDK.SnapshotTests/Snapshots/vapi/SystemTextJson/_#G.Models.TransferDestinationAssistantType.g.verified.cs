//HintName: G.Models.TransferDestinationAssistantType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferDestinationAssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationAssistantType value)
        {
            return value switch
            {
                TransferDestinationAssistantType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TransferDestinationAssistantType.Assistant,
                _ => null,
            };
        }
    }
}