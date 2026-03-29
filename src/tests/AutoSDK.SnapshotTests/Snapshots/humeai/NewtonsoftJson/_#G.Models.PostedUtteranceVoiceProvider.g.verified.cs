//HintName: G.Models.PostedUtteranceVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostedUtteranceVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CUSTOM")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HUME_AI")]
        HumeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostedUtteranceVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostedUtteranceVoiceProvider value)
        {
            return value switch
            {
                PostedUtteranceVoiceProvider.Custom => "CUSTOM",
                PostedUtteranceVoiceProvider.HumeAi => "HUME_AI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostedUtteranceVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => PostedUtteranceVoiceProvider.Custom,
                "HUME_AI" => PostedUtteranceVoiceProvider.HumeAi,
                _ => null,
            };
        }
    }
}