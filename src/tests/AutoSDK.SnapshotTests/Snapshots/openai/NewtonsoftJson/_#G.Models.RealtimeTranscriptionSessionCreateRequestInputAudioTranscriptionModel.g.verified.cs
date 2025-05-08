//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for transcription, current options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-transcribe")]
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-transcribe")]
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper-1")]
        Whisper1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-transcribe" => RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Gpt4oTranscribe,
                "gpt-4o-mini-transcribe" => RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Gpt4oMiniTranscribe,
                "whisper-1" => RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel.Whisper1,
                _ => null,
            };
        }
    }
}