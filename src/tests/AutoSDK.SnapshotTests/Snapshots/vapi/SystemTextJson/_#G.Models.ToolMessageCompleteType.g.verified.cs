//HintName: G.Models.ToolMessageCompleteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This message is triggered when the tool call is complete.<br/>
    /// This message is triggered immediately without waiting for your server to respond for async tool calls.<br/>
    /// If this message is not provided, the model will be requested to respond.<br/>
    /// If this message is provided, only this message will be spoken and the model will not be requested to come up with a response. It's an exclusive OR.
    /// </summary>
    public enum ToolMessageCompleteType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestComplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageCompleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageCompleteType value)
        {
            return value switch
            {
                ToolMessageCompleteType.RequestComplete => "request-complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageCompleteType? ToEnum(string value)
        {
            return value switch
            {
                "request-complete" => ToolMessageCompleteType.RequestComplete,
                _ => null,
            };
        }
    }
}