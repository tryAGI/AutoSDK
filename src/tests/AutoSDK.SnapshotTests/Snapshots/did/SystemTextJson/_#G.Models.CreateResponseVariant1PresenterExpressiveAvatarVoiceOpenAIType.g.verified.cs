//HintName: G.Models.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}