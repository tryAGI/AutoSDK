//HintName: G.Models.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image => "image",
                PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image,
                "text" => PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}