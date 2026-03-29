//HintName: G.Models.ToolMessageFailedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This message is triggered when the tool call fails.<br/>
    /// This message is never triggered for async tool calls.<br/>
    /// If this message is not provided, the model will be requested to respond.<br/>
    /// If this message is provided, only this message will be spoken and the model will not be requested to come up with a response. It's an exclusive OR.
    /// </summary>
    public enum ToolMessageFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageFailedType value)
        {
            return value switch
            {
                ToolMessageFailedType.RequestFailed => "request-failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageFailedType? ToEnum(string value)
        {
            return value switch
            {
                "request-failed" => ToolMessageFailedType.RequestFailed,
                _ => null,
            };
        }
    }
}