//HintName: G.Models.PromptCachingBetaRequestImageBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCachingBetaRequestImageBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaRequestImageBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaRequestImageBlockType value)
        {
            return value switch
            {
                PromptCachingBetaRequestImageBlockType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaRequestImageBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => PromptCachingBetaRequestImageBlockType.Image,
                _ => null,
            };
        }
    }
}