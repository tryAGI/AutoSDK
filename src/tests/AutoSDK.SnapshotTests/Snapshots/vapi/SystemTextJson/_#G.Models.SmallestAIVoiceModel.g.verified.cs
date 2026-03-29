//HintName: G.Models.SmallestAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Smallest AI voice model to use. Defaults to 'lightning' when not specified.
    /// </summary>
    public enum SmallestAIVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Lightning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmallestAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmallestAIVoiceModel value)
        {
            return value switch
            {
                SmallestAIVoiceModel.Lightning => "lightning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmallestAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning" => SmallestAIVoiceModel.Lightning,
                _ => null,
            };
        }
    }
}