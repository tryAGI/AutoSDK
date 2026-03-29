//HintName: G.Models.ToolMessageCompleteRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is optional and defaults to "assistant".<br/>
    /// When role=assistant, `content` is said out loud.<br/>
    /// When role=system, `content` is passed to the model in a system message. Example:<br/>
    ///     system: default one<br/>
    ///     assistant:<br/>
    ///     user:<br/>
    ///     assistant:<br/>
    ///     user:<br/>
    ///     assistant:<br/>
    ///     user:<br/>
    ///     assistant: tool called<br/>
    ///     tool: your server response<br/>
    ///     &lt;--- system prompt as hint<br/>
    ///     ---&gt; model generates response which is spoken<br/>
    /// This is useful when you want to provide a hint to the model about what to say next.
    /// </summary>
    public enum ToolMessageCompleteRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageCompleteRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageCompleteRole value)
        {
            return value switch
            {
                ToolMessageCompleteRole.Assistant => "assistant",
                ToolMessageCompleteRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageCompleteRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ToolMessageCompleteRole.Assistant,
                "system" => ToolMessageCompleteRole.System,
                _ => null,
            };
        }
    }
}