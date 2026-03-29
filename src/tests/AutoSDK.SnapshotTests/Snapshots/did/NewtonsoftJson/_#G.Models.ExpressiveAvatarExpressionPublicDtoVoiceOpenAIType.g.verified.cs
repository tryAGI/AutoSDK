//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType
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
    public static class ExpressiveAvatarExpressionPublicDtoVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ExpressiveAvatarExpressionPublicDtoVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}