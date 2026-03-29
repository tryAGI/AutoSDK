//HintName: G.Models.FallbackTalkscriberTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum FallbackTalkscriberTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackTalkscriberTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackTalkscriberTranscriberModel value)
        {
            return value switch
            {
                FallbackTalkscriberTranscriberModel.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackTalkscriberTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper" => FallbackTalkscriberTranscriberModel.Whisper,
                _ => null,
            };
        }
    }
}