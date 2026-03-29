//HintName: G.Models.ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Universal error code space. Modeled after gRPC status codes.<br/>
    /// Every exception in the system carries an ErrorCode. SDK clients map<br/>
    /// 3rd-party errors to these codes at the lowest level. Retry logic,<br/>
    /// HTTP status mapping, and OTEL metrics all key off this enum.<br/>
    /// NOTE: The semantic meaning of these error codes is roughly mapped from the<br/>
    ///     semantic of the gRPC status codes: see<br/>
    ///     https://grpc.io/docs/guides/status-codes/ for details.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        DeadlineExceeded,
        /// <summary>
        /// 
        /// </summary>
        FailedPrecondition,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        InvalidArgument,
        /// <summary>
        /// 
        /// </summary>
        MissingCredits,
        /// <summary>
        /// 
        /// </summary>
        ModerationFailed,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        ResourceExhausted,
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorCode value)
        {
            return value switch
            {
                ErrorCode.AlreadyExists => "ALREADY_EXISTS",
                ErrorCode.DeadlineExceeded => "DEADLINE_EXCEEDED",
                ErrorCode.FailedPrecondition => "FAILED_PRECONDITION",
                ErrorCode.Internal => "INTERNAL",
                ErrorCode.InvalidArgument => "INVALID_ARGUMENT",
                ErrorCode.MissingCredits => "MISSING_CREDITS",
                ErrorCode.ModerationFailed => "MODERATION_FAILED",
                ErrorCode.NotFound => "NOT_FOUND",
                ErrorCode.PermissionDenied => "PERMISSION_DENIED",
                ErrorCode.ResourceExhausted => "RESOURCE_EXHAUSTED",
                ErrorCode.Unauthorized => "UNAUTHORIZED",
                ErrorCode.Unavailable => "UNAVAILABLE",
                ErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "ALREADY_EXISTS" => ErrorCode.AlreadyExists,
                "DEADLINE_EXCEEDED" => ErrorCode.DeadlineExceeded,
                "FAILED_PRECONDITION" => ErrorCode.FailedPrecondition,
                "INTERNAL" => ErrorCode.Internal,
                "INVALID_ARGUMENT" => ErrorCode.InvalidArgument,
                "MISSING_CREDITS" => ErrorCode.MissingCredits,
                "MODERATION_FAILED" => ErrorCode.ModerationFailed,
                "NOT_FOUND" => ErrorCode.NotFound,
                "PERMISSION_DENIED" => ErrorCode.PermissionDenied,
                "RESOURCE_EXHAUSTED" => ErrorCode.ResourceExhausted,
                "UNAUTHORIZED" => ErrorCode.Unauthorized,
                "UNAVAILABLE" => ErrorCode.Unavailable,
                "UNKNOWN" => ErrorCode.Unknown,
                _ => null,
            };
        }
    }
}