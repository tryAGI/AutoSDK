//HintName: G.Models.NeuphonicVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum NeuphonicVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeuphonicVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeuphonicVoiceProvider value)
        {
            return value switch
            {
                NeuphonicVoiceProvider.Neuphonic => "neuphonic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeuphonicVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "neuphonic" => NeuphonicVoiceProvider.Neuphonic,
                _ => null,
            };
        }
    }
}