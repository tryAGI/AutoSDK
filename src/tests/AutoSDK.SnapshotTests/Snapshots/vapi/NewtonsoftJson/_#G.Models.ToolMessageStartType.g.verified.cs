//HintName: G.Models.ToolMessageStartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This message is triggered when the tool call starts.<br/>
    /// This message is never triggered for async tools.<br/>
    /// If this message is not provided, one of the default filler messages "Hold on a sec", "One moment", "Just a sec", "Give me a moment" or "This'll just take a sec" will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolMessageStartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request-start")]
        RequestStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageStartType value)
        {
            return value switch
            {
                ToolMessageStartType.RequestStart => "request-start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageStartType? ToEnum(string value)
        {
            return value switch
            {
                "request-start" => ToolMessageStartType.RequestStart,
                _ => null,
            };
        }
    }
}