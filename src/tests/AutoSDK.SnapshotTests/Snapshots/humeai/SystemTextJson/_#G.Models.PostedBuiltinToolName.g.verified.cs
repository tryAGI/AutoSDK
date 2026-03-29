//HintName: G.Models.PostedBuiltinToolName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostedBuiltinToolName
    {
        /// <summary>
        /// 
        /// </summary>
        HangUp,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostedBuiltinToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostedBuiltinToolName value)
        {
            return value switch
            {
                PostedBuiltinToolName.HangUp => "hang_up",
                PostedBuiltinToolName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostedBuiltinToolName? ToEnum(string value)
        {
            return value switch
            {
                "hang_up" => PostedBuiltinToolName.HangUp,
                "web_search" => PostedBuiltinToolName.WebSearch,
                _ => null,
            };
        }
    }
}