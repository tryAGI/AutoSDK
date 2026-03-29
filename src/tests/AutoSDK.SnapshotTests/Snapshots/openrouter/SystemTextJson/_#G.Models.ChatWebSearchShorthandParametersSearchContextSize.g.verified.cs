//HintName: G.Models.ChatWebSearchShorthandParametersSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
    /// </summary>
    public enum ChatWebSearchShorthandParametersSearchContextSize
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandParametersSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandParametersSearchContextSize value)
        {
            return value switch
            {
                ChatWebSearchShorthandParametersSearchContextSize.High => "high",
                ChatWebSearchShorthandParametersSearchContextSize.Low => "low",
                ChatWebSearchShorthandParametersSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandParametersSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatWebSearchShorthandParametersSearchContextSize.High,
                "low" => ChatWebSearchShorthandParametersSearchContextSize.Low,
                "medium" => ChatWebSearchShorthandParametersSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}