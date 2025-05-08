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
        Whisper1,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
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
                CreateTranscriptionRequestModel.Whisper1 => "whisper-1",
                CreateTranscriptionRequestModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                CreateTranscriptionRequestModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
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
                "whisper-1" => CreateTranscriptionRequestModel.Whisper1,
                "gpt-4o-transcribe" => CreateTranscriptionRequestModel.Gpt4oTranscribe,
                "gpt-4o-mini-transcribe" => CreateTranscriptionRequestModel.Gpt4oMiniTranscribe,
                _ => null,
            };
        }
    }
}