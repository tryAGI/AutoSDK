//HintName: G.Models.FallbackSmallestAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Smallest AI voice model to use. Defaults to 'lightning' when not specified.
    /// </summary>
    public enum FallbackSmallestAIVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Lightning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSmallestAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSmallestAIVoiceModel value)
        {
            return value switch
            {
                FallbackSmallestAIVoiceModel.Lightning => "lightning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSmallestAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "lightning" => FallbackSmallestAIVoiceModel.Lightning,
                _ => null,
            };
        }
    }
}