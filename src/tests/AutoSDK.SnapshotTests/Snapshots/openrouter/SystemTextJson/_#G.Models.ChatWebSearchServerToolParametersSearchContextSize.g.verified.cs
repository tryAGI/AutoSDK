//HintName: G.Models.ChatWebSearchServerToolParametersSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
    /// </summary>
    public enum ChatWebSearchServerToolParametersSearchContextSize
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
    public static class ChatWebSearchServerToolParametersSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchServerToolParametersSearchContextSize value)
        {
            return value switch
            {
                ChatWebSearchServerToolParametersSearchContextSize.High => "high",
                ChatWebSearchServerToolParametersSearchContextSize.Low => "low",
                ChatWebSearchServerToolParametersSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchServerToolParametersSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatWebSearchServerToolParametersSearchContextSize.High,
                "low" => ChatWebSearchServerToolParametersSearchContextSize.Low,
                "medium" => ChatWebSearchServerToolParametersSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}