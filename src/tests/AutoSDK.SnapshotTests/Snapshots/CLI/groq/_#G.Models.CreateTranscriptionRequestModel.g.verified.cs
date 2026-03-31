//HintName: G.Models.CreateTranscriptionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        WhisperLargeV3,
        /// <summary>
        /// 
        /// </summary>
        WhisperLargeV3Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestModel value)
        {
            return value switch
            {
                CreateTranscriptionRequestModel.WhisperLargeV3 => "whisper-large-v3",
                CreateTranscriptionRequestModel.WhisperLargeV3Turbo => "whisper-large-v3-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-large-v3" => CreateTranscriptionRequestModel.WhisperLargeV3,
                "whisper-large-v3-turbo" => CreateTranscriptionRequestModel.WhisperLargeV3Turbo,
                _ => null,
            };
        }
    }
}