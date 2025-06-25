//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-transcribe" => RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Gpt4oTranscribe,
                "gpt-4o-mini-transcribe" => RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Gpt4oMiniTranscribe,
                "whisper-1" => RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel.Whisper1,
                _ => null,
            };
        }
    }
}