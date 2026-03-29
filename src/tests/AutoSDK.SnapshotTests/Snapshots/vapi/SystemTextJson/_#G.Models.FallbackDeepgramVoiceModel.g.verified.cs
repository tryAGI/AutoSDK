//HintName: G.Models.FallbackDeepgramVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'aura-2' when not specified.<br/>
    /// Example: aura-2
    /// </summary>
    public enum FallbackDeepgramVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Aura,
        /// <summary>
        /// 
        /// </summary>
        Aura2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackDeepgramVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackDeepgramVoiceModel value)
        {
            return value switch
            {
                FallbackDeepgramVoiceModel.Aura => "aura",
                FallbackDeepgramVoiceModel.Aura2 => "aura-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackDeepgramVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "aura" => FallbackDeepgramVoiceModel.Aura,
                "aura-2" => FallbackDeepgramVoiceModel.Aura2,
                _ => null,
            };
        }
    }
}