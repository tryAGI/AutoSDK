//HintName: G.Models.UpdateSecretOpenAIRequestDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for OpenAI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretOpenAIRequestDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-openai")]
        ExternalOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretOpenAIRequestDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretOpenAIRequestDtoProvider value)
        {
            return value switch
            {
                UpdateSecretOpenAIRequestDtoProvider.ExternalOpenai => "external-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretOpenAIRequestDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-openai" => UpdateSecretOpenAIRequestDtoProvider.ExternalOpenai,
                _ => null,
            };
        }
    }
}