//HintName: G.Models.FallbackNeuphonicVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackNeuphonicVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neuphonic")]
        Neuphonic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackNeuphonicVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackNeuphonicVoiceProvider value)
        {
            return value switch
            {
                FallbackNeuphonicVoiceProvider.Neuphonic => "neuphonic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackNeuphonicVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "neuphonic" => FallbackNeuphonicVoiceProvider.Neuphonic,
                _ => null,
            };
        }
    }
}