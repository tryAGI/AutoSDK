//HintName: G.Models.PromptCachingBetaToolCacheControlDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaToolCacheControlDiscriminatorType
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
    public static class PromptCachingBetaToolCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaToolCacheControlDiscriminatorType value)
        {
            return value switch
            {
                PromptCachingBetaToolCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaToolCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => PromptCachingBetaToolCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}