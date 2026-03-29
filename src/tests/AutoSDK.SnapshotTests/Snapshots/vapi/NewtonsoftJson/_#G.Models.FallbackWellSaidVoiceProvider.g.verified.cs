//HintName: G.Models.FallbackWellSaidVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackWellSaidVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wellsaid")]
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackWellSaidVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackWellSaidVoiceProvider value)
        {
            return value switch
            {
                FallbackWellSaidVoiceProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackWellSaidVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "wellsaid" => FallbackWellSaidVoiceProvider.Wellsaid,
                _ => null,
            };
        }
    }
}