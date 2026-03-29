//HintName: G.Models.TalkscriberTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum TalkscriberTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TalkscriberTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalkscriberTranscriberModel value)
        {
            return value switch
            {
                TalkscriberTranscriberModel.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalkscriberTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper" => TalkscriberTranscriberModel.Whisper,
                _ => null,
            };
        }
    }
}