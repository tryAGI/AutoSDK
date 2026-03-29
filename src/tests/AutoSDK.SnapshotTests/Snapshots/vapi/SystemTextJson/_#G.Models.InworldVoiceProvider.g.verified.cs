//HintName: G.Models.InworldVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum InworldVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InworldVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InworldVoiceProvider value)
        {
            return value switch
            {
                InworldVoiceProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InworldVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "inworld" => InworldVoiceProvider.Inworld,
                _ => null,
            };
        }
    }
}