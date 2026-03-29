//HintName: G.Models.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus value)
        {
            return value switch
            {
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Created => "created",
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Done => "done",
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Error => "error",
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Ready => "ready",
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Rejected => "rejected",
                PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Created,
                "done" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Done,
                "error" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Error,
                "ready" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Ready,
                "rejected" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Rejected,
                "validating" => PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.Validating,
                _ => null,
            };
        }
    }
}