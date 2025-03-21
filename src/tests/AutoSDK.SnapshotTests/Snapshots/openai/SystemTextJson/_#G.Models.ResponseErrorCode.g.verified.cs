//HintName: G.Models.ResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The error code for the response.
    /// </summary>
    public enum ResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidPrompt,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreTimeout,
        /// <summary>
        /// 
        /// </summary>
        InvalidImage,
        /// <summary>
        /// 
        /// </summary>
        InvalidImageFormat,
        /// <summary>
        /// 
        /// </summary>
        InvalidBase64Image,
        /// <summary>
        /// 
        /// </summary>
        InvalidImageUrl,
        /// <summary>
        /// 
        /// </summary>
        ImageTooLarge,
        /// <summary>
        /// 
        /// </summary>
        ImageTooSmall,
        /// <summary>
        /// 
        /// </summary>
        ImageParseError,
        /// <summary>
        /// 
        /// </summary>
        ImageContentPolicyViolation,
        /// <summary>
        /// 
        /// </summary>
        InvalidImageMode,
        /// <summary>
        /// 
        /// </summary>
        ImageFileTooLarge,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedImageMediaType,
        /// <summary>
        /// 
        /// </summary>
        EmptyImageFile,
        /// <summary>
        /// 
        /// </summary>
        FailedToDownloadImage,
        /// <summary>
        /// 
        /// </summary>
        ImageFileNotFound,
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
                ResponseErrorCode.ServerError => "server_error",
                ResponseErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                ResponseErrorCode.InvalidPrompt => "invalid_prompt",
                ResponseErrorCode.VectorStoreTimeout => "vector_store_timeout",
                ResponseErrorCode.InvalidImage => "invalid_image",
                ResponseErrorCode.InvalidImageFormat => "invalid_image_format",
                ResponseErrorCode.InvalidBase64Image => "invalid_base64_image",
                ResponseErrorCode.InvalidImageUrl => "invalid_image_url",
                ResponseErrorCode.ImageTooLarge => "image_too_large",
                ResponseErrorCode.ImageTooSmall => "image_too_small",
                ResponseErrorCode.ImageParseError => "image_parse_error",
                ResponseErrorCode.ImageContentPolicyViolation => "image_content_policy_violation",
                ResponseErrorCode.InvalidImageMode => "invalid_image_mode",
                ResponseErrorCode.ImageFileTooLarge => "image_file_too_large",
                ResponseErrorCode.UnsupportedImageMediaType => "unsupported_image_media_type",
                ResponseErrorCode.EmptyImageFile => "empty_image_file",
                ResponseErrorCode.FailedToDownloadImage => "failed_to_download_image",
                ResponseErrorCode.ImageFileNotFound => "image_file_not_found",
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
                "server_error" => ResponseErrorCode.ServerError,
                "rate_limit_exceeded" => ResponseErrorCode.RateLimitExceeded,
                "invalid_prompt" => ResponseErrorCode.InvalidPrompt,
                "vector_store_timeout" => ResponseErrorCode.VectorStoreTimeout,
                "invalid_image" => ResponseErrorCode.InvalidImage,
                "invalid_image_format" => ResponseErrorCode.InvalidImageFormat,
                "invalid_base64_image" => ResponseErrorCode.InvalidBase64Image,
                "invalid_image_url" => ResponseErrorCode.InvalidImageUrl,
                "image_too_large" => ResponseErrorCode.ImageTooLarge,
                "image_too_small" => ResponseErrorCode.ImageTooSmall,
                "image_parse_error" => ResponseErrorCode.ImageParseError,
                "image_content_policy_violation" => ResponseErrorCode.ImageContentPolicyViolation,
                "invalid_image_mode" => ResponseErrorCode.InvalidImageMode,
                "image_file_too_large" => ResponseErrorCode.ImageFileTooLarge,
                "unsupported_image_media_type" => ResponseErrorCode.UnsupportedImageMediaType,
                "empty_image_file" => ResponseErrorCode.EmptyImageFile,
                "failed_to_download_image" => ResponseErrorCode.FailedToDownloadImage,
                "image_file_not_found" => ResponseErrorCode.ImageFileNotFound,
                _ => null,
            };
        }
    }
}