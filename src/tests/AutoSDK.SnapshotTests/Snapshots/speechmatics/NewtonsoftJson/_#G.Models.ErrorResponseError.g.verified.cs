//HintName: G.Models.ErrorResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The error message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ErrorResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bad Request")]
        BadRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="File Expired")]
        FileExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Forbidden")]
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Format Not Supported")]
        FormatNotSupported,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Internal Server Error")]
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job Expired")]
        JobExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job In Progress")]
        JobInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job error")]
        JobError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job is not of type alignment")]
        JobIsNotOfTypeAlignment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job is not of type transcription")]
        JobIsNotOfTypeTranscription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job not found")]
        JobNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job rejected")]
        JobRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job rejected due to invalid audio")]
        JobRejectedDueToInvalidAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Job rejected due to invalid text")]
        JobRejectedDueToInvalidText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Log file not available")]
        LogFileNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Malformed request")]
        MalformedRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Missing callback")]
        MissingCallback,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Missing data_file")]
        MissingDataFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Missing text_file")]
        MissingTextFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="No language selected")]
        NoLanguageSelected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Not Implemented")]
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Permission Denied")]
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Requested Early Access Release not available")]
        RequestedEarlyAccessReleaseNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Requested product not available")]
        RequestedProductNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Resource Locked")]
        ResourceLocked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Transcription not ready")]
        TranscriptionNotReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unprocessable Entity")]
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorResponseErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseError value)
        {
            return value switch
            {
                ErrorResponseError.BadRequest => "Bad Request",
                ErrorResponseError.FileExpired => "File Expired",
                ErrorResponseError.Forbidden => "Forbidden",
                ErrorResponseError.FormatNotSupported => "Format Not Supported",
                ErrorResponseError.InternalServerError => "Internal Server Error",
                ErrorResponseError.JobExpired => "Job Expired",
                ErrorResponseError.JobInProgress => "Job In Progress",
                ErrorResponseError.JobError => "Job error",
                ErrorResponseError.JobIsNotOfTypeAlignment => "Job is not of type alignment",
                ErrorResponseError.JobIsNotOfTypeTranscription => "Job is not of type transcription",
                ErrorResponseError.JobNotFound => "Job not found",
                ErrorResponseError.JobRejected => "Job rejected",
                ErrorResponseError.JobRejectedDueToInvalidAudio => "Job rejected due to invalid audio",
                ErrorResponseError.JobRejectedDueToInvalidText => "Job rejected due to invalid text",
                ErrorResponseError.LogFileNotAvailable => "Log file not available",
                ErrorResponseError.MalformedRequest => "Malformed request",
                ErrorResponseError.MissingCallback => "Missing callback",
                ErrorResponseError.MissingDataFile => "Missing data_file",
                ErrorResponseError.MissingTextFile => "Missing text_file",
                ErrorResponseError.NoLanguageSelected => "No language selected",
                ErrorResponseError.NotImplemented => "Not Implemented",
                ErrorResponseError.PermissionDenied => "Permission Denied",
                ErrorResponseError.RequestedEarlyAccessReleaseNotAvailable => "Requested Early Access Release not available",
                ErrorResponseError.RequestedProductNotAvailable => "Requested product not available",
                ErrorResponseError.ResourceLocked => "Resource Locked",
                ErrorResponseError.TranscriptionNotReady => "Transcription not ready",
                ErrorResponseError.UnprocessableEntity => "Unprocessable Entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseError? ToEnum(string value)
        {
            return value switch
            {
                "Bad Request" => ErrorResponseError.BadRequest,
                "File Expired" => ErrorResponseError.FileExpired,
                "Forbidden" => ErrorResponseError.Forbidden,
                "Format Not Supported" => ErrorResponseError.FormatNotSupported,
                "Internal Server Error" => ErrorResponseError.InternalServerError,
                "Job Expired" => ErrorResponseError.JobExpired,
                "Job In Progress" => ErrorResponseError.JobInProgress,
                "Job error" => ErrorResponseError.JobError,
                "Job is not of type alignment" => ErrorResponseError.JobIsNotOfTypeAlignment,
                "Job is not of type transcription" => ErrorResponseError.JobIsNotOfTypeTranscription,
                "Job not found" => ErrorResponseError.JobNotFound,
                "Job rejected" => ErrorResponseError.JobRejected,
                "Job rejected due to invalid audio" => ErrorResponseError.JobRejectedDueToInvalidAudio,
                "Job rejected due to invalid text" => ErrorResponseError.JobRejectedDueToInvalidText,
                "Log file not available" => ErrorResponseError.LogFileNotAvailable,
                "Malformed request" => ErrorResponseError.MalformedRequest,
                "Missing callback" => ErrorResponseError.MissingCallback,
                "Missing data_file" => ErrorResponseError.MissingDataFile,
                "Missing text_file" => ErrorResponseError.MissingTextFile,
                "No language selected" => ErrorResponseError.NoLanguageSelected,
                "Not Implemented" => ErrorResponseError.NotImplemented,
                "Permission Denied" => ErrorResponseError.PermissionDenied,
                "Requested Early Access Release not available" => ErrorResponseError.RequestedEarlyAccessReleaseNotAvailable,
                "Requested product not available" => ErrorResponseError.RequestedProductNotAvailable,
                "Resource Locked" => ErrorResponseError.ResourceLocked,
                "Transcription not ready" => ErrorResponseError.TranscriptionNotReady,
                "Unprocessable Entity" => ErrorResponseError.UnprocessableEntity,
                _ => null,
            };
        }
    }
}