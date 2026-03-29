//HintName: G.Models.DeepgramVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'aura-2' when not specified.<br/>
    /// Example: aura-2
    /// </summary>
    public enum DeepgramVoiceModel
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
    public static class DeepgramVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramVoiceModel value)
        {
            return value switch
            {
                DeepgramVoiceModel.Aura => "aura",
                DeepgramVoiceModel.Aura2 => "aura-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "aura" => DeepgramVoiceModel.Aura,
                "aura-2" => DeepgramVoiceModel.Aura2,
                _ => null,
            };
        }
    }
}