//HintName: G.Models.PromptCachingBetaRequestTextBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaRequestTextBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaRequestTextBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaRequestTextBlockType value)
        {
            return value switch
            {
                PromptCachingBetaRequestTextBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaRequestTextBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => PromptCachingBetaRequestTextBlockType.Text,
                _ => null,
            };
        }
    }
}