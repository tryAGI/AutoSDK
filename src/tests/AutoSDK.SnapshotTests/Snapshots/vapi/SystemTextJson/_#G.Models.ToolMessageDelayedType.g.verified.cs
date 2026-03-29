//HintName: G.Models.ToolMessageDelayedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This message is triggered when the tool call is delayed.<br/>
    /// There are the two things that can trigger this message:<br/>
    /// 1. The user talks with the assistant while your server is processing the request. Default is "Sorry, a few more seconds."<br/>
    /// 2. The server doesn't respond within `timingMilliseconds`.<br/>
    /// This message is never triggered for async tool calls.
    /// </summary>
    public enum ToolMessageDelayedType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestResponseDelayed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageDelayedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageDelayedType value)
        {
            return value switch
            {
                ToolMessageDelayedType.RequestResponseDelayed => "request-response-delayed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageDelayedType? ToEnum(string value)
        {
            return value switch
            {
                "request-response-delayed" => ToolMessageDelayedType.RequestResponseDelayed,
                _ => null,
            };
        }
    }
}