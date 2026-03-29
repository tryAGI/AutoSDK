//HintName: G.Models.FallbackSmallestAIVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackSmallestAIVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smallest-ai")]
        SmallestAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSmallestAIVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSmallestAIVoiceProvider value)
        {
            return value switch
            {
                FallbackSmallestAIVoiceProvider.SmallestAi => "smallest-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSmallestAIVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "smallest-ai" => FallbackSmallestAIVoiceProvider.SmallestAi,
                _ => null,
            };
        }
    }
}