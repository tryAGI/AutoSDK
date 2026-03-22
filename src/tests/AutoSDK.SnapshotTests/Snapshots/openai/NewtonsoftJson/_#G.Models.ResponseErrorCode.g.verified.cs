//HintName: G.Models.ResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The error code for the response.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="empty_image_file")]
        EmptyImageFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed_to_download_image")]
        FailedToDownloadImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_content_policy_violation")]
        ImageContentPolicyViolation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_file_not_found")]
        ImageFileNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_file_too_large")]
        ImageFileTooLarge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_parse_error")]
        ImageParseError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_too_large")]
        ImageTooLarge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_too_small")]
        ImageTooSmall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_base64_image")]
        InvalidBase64Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_image")]
        InvalidImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_image_format")]
        InvalidImageFormat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_image_mode")]
        InvalidImageMode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_image_url")]
        InvalidImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_prompt")]
        InvalidPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_exceeded")]
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsupported_image_media_type")]
        UnsupportedImageMediaType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store_timeout")]
        VectorStoreTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseErrorCode value)
        {
            return value switch
            {
                ResponseErrorCode.EmptyImageFile => "empty_image_file",
                ResponseErrorCode.FailedToDownloadImage => "failed_to_download_image",
                ResponseErrorCode.ImageContentPolicyViolation => "image_content_policy_violation",
                ResponseErrorCode.ImageFileNotFound => "image_file_not_found",
                ResponseErrorCode.ImageFileTooLarge => "image_file_too_large",
                ResponseErrorCode.ImageParseError => "image_parse_error",
                ResponseErrorCode.ImageTooLarge => "image_too_large",
                ResponseErrorCode.ImageTooSmall => "image_too_small",
                ResponseErrorCode.InvalidBase64Image => "invalid_base64_image",
                ResponseErrorCode.InvalidImage => "invalid_image",
                ResponseErrorCode.InvalidImageFormat => "invalid_image_format",
                ResponseErrorCode.InvalidImageMode => "invalid_image_mode",
                ResponseErrorCode.InvalidImageUrl => "invalid_image_url",
                ResponseErrorCode.InvalidPrompt => "invalid_prompt",
                ResponseErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                ResponseErrorCode.ServerError => "server_error",
                ResponseErrorCode.UnsupportedImageMediaType => "unsupported_image_media_type",
                ResponseErrorCode.VectorStoreTimeout => "vector_store_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "empty_image_file" => ResponseErrorCode.EmptyImageFile,
                "failed_to_download_image" => ResponseErrorCode.FailedToDownloadImage,
                "image_content_policy_violation" => ResponseErrorCode.ImageContentPolicyViolation,
                "image_file_not_found" => ResponseErrorCode.ImageFileNotFound,
                "image_file_too_large" => ResponseErrorCode.ImageFileTooLarge,
                "image_parse_error" => ResponseErrorCode.ImageParseError,
                "image_too_large" => ResponseErrorCode.ImageTooLarge,
                "image_too_small" => ResponseErrorCode.ImageTooSmall,
                "invalid_base64_image" => ResponseErrorCode.InvalidBase64Image,
                "invalid_image" => ResponseErrorCode.InvalidImage,
                "invalid_image_format" => ResponseErrorCode.InvalidImageFormat,
                "invalid_image_mode" => ResponseErrorCode.InvalidImageMode,
                "invalid_image_url" => ResponseErrorCode.InvalidImageUrl,
                "invalid_prompt" => ResponseErrorCode.InvalidPrompt,
                "rate_limit_exceeded" => ResponseErrorCode.RateLimitExceeded,
                "server_error" => ResponseErrorCode.ServerError,
                "unsupported_image_media_type" => ResponseErrorCode.UnsupportedImageMediaType,
                "vector_store_timeout" => ResponseErrorCode.VectorStoreTimeout,
                _ => null,
            };
        }
    }
}