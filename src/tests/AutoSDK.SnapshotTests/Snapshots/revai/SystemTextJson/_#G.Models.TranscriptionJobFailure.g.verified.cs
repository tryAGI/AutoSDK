//HintName: G.Models.TranscriptionJobFailure.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reason for job failure
    /// </summary>
    public enum TranscriptionJobFailure
    {
        /// <summary>
        /// 
        /// </summary>
        DownloadFailure,
        /// <summary>
        /// 
        /// </summary>
        DurationExceeded,
        /// <summary>
        /// 
        /// </summary>
        DurationTooShort,
        /// <summary>
        /// 
        /// </summary>
        EmptyMedia,
        /// <summary>
        /// 
        /// </summary>
        InsufficientBalance,
        /// <summary>
        /// 
        /// </summary>
        InternalProcessing,
        /// <summary>
        /// 
        /// </summary>
        InvalidMedia,
        /// <summary>
        /// 
        /// </summary>
        InvoicingLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionJobFailureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionJobFailure value)
        {
            return value switch
            {
                TranscriptionJobFailure.DownloadFailure => "download_failure",
                TranscriptionJobFailure.DurationExceeded => "duration_exceeded",
                TranscriptionJobFailure.DurationTooShort => "duration_too_short",
                TranscriptionJobFailure.EmptyMedia => "empty_media",
                TranscriptionJobFailure.InsufficientBalance => "insufficient_balance",
                TranscriptionJobFailure.InternalProcessing => "internal_processing",
                TranscriptionJobFailure.InvalidMedia => "invalid_media",
                TranscriptionJobFailure.InvoicingLimitExceeded => "invoicing_limit_exceeded",
                TranscriptionJobFailure.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionJobFailure? ToEnum(string value)
        {
            return value switch
            {
                "download_failure" => TranscriptionJobFailure.DownloadFailure,
                "duration_exceeded" => TranscriptionJobFailure.DurationExceeded,
                "duration_too_short" => TranscriptionJobFailure.DurationTooShort,
                "empty_media" => TranscriptionJobFailure.EmptyMedia,
                "insufficient_balance" => TranscriptionJobFailure.InsufficientBalance,
                "internal_processing" => TranscriptionJobFailure.InternalProcessing,
                "invalid_media" => TranscriptionJobFailure.InvalidMedia,
                "invoicing_limit_exceeded" => TranscriptionJobFailure.InvoicingLimitExceeded,
                "transcription" => TranscriptionJobFailure.Transcription,
                _ => null,
            };
        }
    }
}