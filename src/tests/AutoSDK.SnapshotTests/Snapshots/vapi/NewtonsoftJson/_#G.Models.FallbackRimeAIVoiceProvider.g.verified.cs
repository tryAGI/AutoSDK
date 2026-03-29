//HintName: G.Models.FallbackRimeAIVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackRimeAIVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rime-ai")]
        RimeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackRimeAIVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackRimeAIVoiceProvider value)
        {
            return value switch
            {
                FallbackRimeAIVoiceProvider.RimeAi => "rime-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackRimeAIVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "rime-ai" => FallbackRimeAIVoiceProvider.RimeAi,
                _ => null,
            };
        }
    }
}