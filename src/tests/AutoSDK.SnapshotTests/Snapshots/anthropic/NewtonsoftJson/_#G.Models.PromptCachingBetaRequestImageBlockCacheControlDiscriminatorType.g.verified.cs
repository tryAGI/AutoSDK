//HintName: G.Models.PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaRequestImageBlockCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType value)
        {
            return value switch
            {
                PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => PromptCachingBetaRequestImageBlockCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}