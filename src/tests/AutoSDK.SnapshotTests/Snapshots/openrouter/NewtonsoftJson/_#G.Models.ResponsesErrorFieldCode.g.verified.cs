//HintName: G.Models.ResponsesErrorFieldCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponsesErrorFieldCode
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
    public static class ResponsesErrorFieldCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesErrorFieldCode value)
        {
            return value switch
            {
                ResponsesErrorFieldCode.EmptyImageFile => "empty_image_file",
                ResponsesErrorFieldCode.FailedToDownloadImage => "failed_to_download_image",
                ResponsesErrorFieldCode.ImageContentPolicyViolation => "image_content_policy_violation",
                ResponsesErrorFieldCode.ImageFileNotFound => "image_file_not_found",
                ResponsesErrorFieldCode.ImageFileTooLarge => "image_file_too_large",
                ResponsesErrorFieldCode.ImageParseError => "image_parse_error",
                ResponsesErrorFieldCode.ImageTooLarge => "image_too_large",
                ResponsesErrorFieldCode.ImageTooSmall => "image_too_small",
                ResponsesErrorFieldCode.InvalidBase64Image => "invalid_base64_image",
                ResponsesErrorFieldCode.InvalidImage => "invalid_image",
                ResponsesErrorFieldCode.InvalidImageFormat => "invalid_image_format",
                ResponsesErrorFieldCode.InvalidImageMode => "invalid_image_mode",
                ResponsesErrorFieldCode.InvalidImageUrl => "invalid_image_url",
                ResponsesErrorFieldCode.InvalidPrompt => "invalid_prompt",
                ResponsesErrorFieldCode.RateLimitExceeded => "rate_limit_exceeded",
                ResponsesErrorFieldCode.ServerError => "server_error",
                ResponsesErrorFieldCode.UnsupportedImageMediaType => "unsupported_image_media_type",
                ResponsesErrorFieldCode.VectorStoreTimeout => "vector_store_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesErrorFieldCode? ToEnum(string value)
        {
            return value switch
            {
                "empty_image_file" => ResponsesErrorFieldCode.EmptyImageFile,
                "failed_to_download_image" => ResponsesErrorFieldCode.FailedToDownloadImage,
                "image_content_policy_violation" => ResponsesErrorFieldCode.ImageContentPolicyViolation,
                "image_file_not_found" => ResponsesErrorFieldCode.ImageFileNotFound,
                "image_file_too_large" => ResponsesErrorFieldCode.ImageFileTooLarge,
                "image_parse_error" => ResponsesErrorFieldCode.ImageParseError,
                "image_too_large" => ResponsesErrorFieldCode.ImageTooLarge,
                "image_too_small" => ResponsesErrorFieldCode.ImageTooSmall,
                "invalid_base64_image" => ResponsesErrorFieldCode.InvalidBase64Image,
                "invalid_image" => ResponsesErrorFieldCode.InvalidImage,
                "invalid_image_format" => ResponsesErrorFieldCode.InvalidImageFormat,
                "invalid_image_mode" => ResponsesErrorFieldCode.InvalidImageMode,
                "invalid_image_url" => ResponsesErrorFieldCode.InvalidImageUrl,
                "invalid_prompt" => ResponsesErrorFieldCode.InvalidPrompt,
                "rate_limit_exceeded" => ResponsesErrorFieldCode.RateLimitExceeded,
                "server_error" => ResponsesErrorFieldCode.ServerError,
                "unsupported_image_media_type" => ResponsesErrorFieldCode.UnsupportedImageMediaType,
                "vector_store_timeout" => ResponsesErrorFieldCode.VectorStoreTimeout,
                _ => null,
            };
        }
    }
}