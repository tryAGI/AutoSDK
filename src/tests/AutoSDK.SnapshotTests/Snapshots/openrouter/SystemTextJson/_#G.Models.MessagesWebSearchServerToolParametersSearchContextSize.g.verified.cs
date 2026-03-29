//HintName: G.Models.MessagesWebSearchServerToolParametersSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
    /// </summary>
    public enum MessagesWebSearchServerToolParametersSearchContextSize
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
    public static class MessagesWebSearchServerToolParametersSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesWebSearchServerToolParametersSearchContextSize value)
        {
            return value switch
            {
                MessagesWebSearchServerToolParametersSearchContextSize.High => "high",
                MessagesWebSearchServerToolParametersSearchContextSize.Low => "low",
                MessagesWebSearchServerToolParametersSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesWebSearchServerToolParametersSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => MessagesWebSearchServerToolParametersSearchContextSize.High,
                "low" => MessagesWebSearchServerToolParametersSearchContextSize.Low,
                "medium" => MessagesWebSearchServerToolParametersSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}