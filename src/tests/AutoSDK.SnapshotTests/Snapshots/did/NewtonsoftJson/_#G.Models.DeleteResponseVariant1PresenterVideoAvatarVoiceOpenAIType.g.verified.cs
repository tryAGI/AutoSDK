//HintName: G.Models.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}