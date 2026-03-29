//HintName: G.Models.UrlMetadataUrlRetrievalStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the url retrieval.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UrlMetadataUrlRetrievalStatus
    {
        /// <summary>
        /// Url retrieval is failed due to error.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_RETRIEVAL_STATUS_ERROR")]
        UrlRetrievalStatusError,
        /// <summary>
        /// Url retrieval is failed because the content is behind paywall.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_RETRIEVAL_STATUS_PAYWALL")]
        UrlRetrievalStatusPaywall,
        /// <summary>
        /// Url retrieval is successful.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_RETRIEVAL_STATUS_SUCCESS")]
        UrlRetrievalStatusSuccess,
        /// <summary>
        /// Url retrieval is failed because the content is unsafe.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_RETRIEVAL_STATUS_UNSAFE")]
        UrlRetrievalStatusUnsafe,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_RETRIEVAL_STATUS_UNSPECIFIED")]
        UrlRetrievalStatusUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlMetadataUrlRetrievalStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlMetadataUrlRetrievalStatus value)
        {
            return value switch
            {
                UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusError => "URL_RETRIEVAL_STATUS_ERROR",
                UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusPaywall => "URL_RETRIEVAL_STATUS_PAYWALL",
                UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusSuccess => "URL_RETRIEVAL_STATUS_SUCCESS",
                UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusUnsafe => "URL_RETRIEVAL_STATUS_UNSAFE",
                UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusUnspecified => "URL_RETRIEVAL_STATUS_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlMetadataUrlRetrievalStatus? ToEnum(string value)
        {
            return value switch
            {
                "URL_RETRIEVAL_STATUS_ERROR" => UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusError,
                "URL_RETRIEVAL_STATUS_PAYWALL" => UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusPaywall,
                "URL_RETRIEVAL_STATUS_SUCCESS" => UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusSuccess,
                "URL_RETRIEVAL_STATUS_UNSAFE" => UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusUnsafe,
                "URL_RETRIEVAL_STATUS_UNSPECIFIED" => UrlMetadataUrlRetrievalStatus.UrlRetrievalStatusUnspecified,
                _ => null,
            };
        }
    }
}