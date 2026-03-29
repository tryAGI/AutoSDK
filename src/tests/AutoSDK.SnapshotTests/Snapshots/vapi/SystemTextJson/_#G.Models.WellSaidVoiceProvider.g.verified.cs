//HintName: G.Models.WellSaidVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum WellSaidVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WellSaidVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WellSaidVoiceProvider value)
        {
            return value switch
            {
                WellSaidVoiceProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WellSaidVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "wellsaid" => WellSaidVoiceProvider.Wellsaid,
                _ => null,
            };
        }
    }
}