//HintName: G.Models.FallbackMinimaxVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackMinimaxVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimax")]
        Minimax,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMinimaxVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMinimaxVoiceProvider value)
        {
            return value switch
            {
                FallbackMinimaxVoiceProvider.Minimax => "minimax",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMinimaxVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "minimax" => FallbackMinimaxVoiceProvider.Minimax,
                _ => null,
            };
        }
    }
}