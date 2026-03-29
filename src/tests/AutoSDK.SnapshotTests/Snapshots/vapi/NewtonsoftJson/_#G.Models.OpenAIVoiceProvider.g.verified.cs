//HintName: G.Models.OpenAIVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoiceProvider value)
        {
            return value switch
            {
                OpenAIVoiceProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIVoiceProvider.Openai,
                _ => null,
            };
        }
    }
}