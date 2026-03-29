//HintName: G.Models.StoreEventHistogramBucketType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the event
    /// </summary>
    public enum StoreEventHistogramBucketType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyRerolled,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyRevoked,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        AuthError,
        /// <summary>
        /// 
        /// </summary>
        AuthInvalidToken,
        /// <summary>
        /// 
        /// </summary>
        AuthSuccess,
        /// <summary>
        /// 
        /// </summary>
        DataSourceConnectorJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        DataSourceCreated,
        /// <summary>
        /// 
        /// </summary>
        DataSourceDeleted,
        /// <summary>
        /// 
        /// </summary>
        DataSourceOauth2Authorized,
        /// <summary>
        /// 
        /// </summary>
        DataSourceOauth2Requested,
        /// <summary>
        /// 
        /// </summary>
        DataSourceUpdated,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCancelled,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobCreated,
        /// <summary>
        /// 
        /// </summary>
        ExtractionJobDeleted,
        /// <summary>
        /// 
        /// </summary>
        FileDeleted,
        /// <summary>
        /// 
        /// </summary>
        FileDownloaded,
        /// <summary>
        /// 
        /// </summary>
        FileUpdated,
        /// <summary>
        /// 
        /// </summary>
        FileUploaded,
        /// <summary>
        /// 
        /// </summary>
        InferenceEmbeddings,
        /// <summary>
        /// 
        /// </summary>
        InferenceReranking,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        ModelRequest,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCancelled,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCompleted,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobCreated,
        /// <summary>
        /// 
        /// </summary>
        ParsingJobDeleted,
        /// <summary>
        /// 
        /// </summary>
        StoreCreated,
        /// <summary>
        /// 
        /// </summary>
        StoreDeleted,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCancelled,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCompleted,
        /// <summary>
        /// 
        /// </summary>
        StoreFileCreated,
        /// <summary>
        /// 
        /// </summary>
        StoreFileDeleted,
        /// <summary>
        /// 
        /// </summary>
        StoreFileSearch,
        /// <summary>
        /// 
        /// </summary>
        StoreFileUpdated,
        /// <summary>
        /// 
        /// </summary>
        StoreQuestionAnswer,
        /// <summary>
        /// 
        /// </summary>
        StoreReingestionCompleted,
        /// <summary>
        /// 
        /// </summary>
        StoreSearch,
        /// <summary>
        /// 
        /// </summary>
        StoreUpdated,
        /// <summary>
        /// 
        /// </summary>
        StoreWebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreEventHistogramBucketTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreEventHistogramBucketType value)
        {
            return value switch
            {
                StoreEventHistogramBucketType.ApiKeyCreated => "api_key.created",
                StoreEventHistogramBucketType.ApiKeyDeleted => "api_key.deleted",
                StoreEventHistogramBucketType.ApiKeyRerolled => "api_key.rerolled",
                StoreEventHistogramBucketType.ApiKeyRevoked => "api_key.revoked",
                StoreEventHistogramBucketType.ApiKeyUpdated => "api_key.updated",
                StoreEventHistogramBucketType.AuthError => "auth.error",
                StoreEventHistogramBucketType.AuthInvalidToken => "auth.invalid_token",
                StoreEventHistogramBucketType.AuthSuccess => "auth.success",
                StoreEventHistogramBucketType.DataSourceConnectorJobCompleted => "data_source.connector.job.completed",
                StoreEventHistogramBucketType.DataSourceCreated => "data_source.created",
                StoreEventHistogramBucketType.DataSourceDeleted => "data_source.deleted",
                StoreEventHistogramBucketType.DataSourceOauth2Authorized => "data_source.oauth2.authorized",
                StoreEventHistogramBucketType.DataSourceOauth2Requested => "data_source.oauth2.requested",
                StoreEventHistogramBucketType.DataSourceUpdated => "data_source.updated",
                StoreEventHistogramBucketType.ExtractionJobCancelled => "extraction.job.cancelled",
                StoreEventHistogramBucketType.ExtractionJobCompleted => "extraction.job.completed",
                StoreEventHistogramBucketType.ExtractionJobCreated => "extraction.job.created",
                StoreEventHistogramBucketType.ExtractionJobDeleted => "extraction.job.deleted",
                StoreEventHistogramBucketType.FileDeleted => "file.deleted",
                StoreEventHistogramBucketType.FileDownloaded => "file.downloaded",
                StoreEventHistogramBucketType.FileUpdated => "file.updated",
                StoreEventHistogramBucketType.FileUploaded => "file.uploaded",
                StoreEventHistogramBucketType.InferenceEmbeddings => "inference.embeddings",
                StoreEventHistogramBucketType.InferenceReranking => "inference.reranking",
                StoreEventHistogramBucketType.InternalError => "internal_error",
                StoreEventHistogramBucketType.ModelRequest => "model_request",
                StoreEventHistogramBucketType.ParsingJobCancelled => "parsing.job.cancelled",
                StoreEventHistogramBucketType.ParsingJobCompleted => "parsing.job.completed",
                StoreEventHistogramBucketType.ParsingJobCreated => "parsing.job.created",
                StoreEventHistogramBucketType.ParsingJobDeleted => "parsing.job.deleted",
                StoreEventHistogramBucketType.StoreCreated => "store.created",
                StoreEventHistogramBucketType.StoreDeleted => "store.deleted",
                StoreEventHistogramBucketType.StoreFileCancelled => "store.file.cancelled",
                StoreEventHistogramBucketType.StoreFileCompleted => "store.file.completed",
                StoreEventHistogramBucketType.StoreFileCreated => "store.file.created",
                StoreEventHistogramBucketType.StoreFileDeleted => "store.file.deleted",
                StoreEventHistogramBucketType.StoreFileSearch => "store.file.search",
                StoreEventHistogramBucketType.StoreFileUpdated => "store.file.updated",
                StoreEventHistogramBucketType.StoreQuestionAnswer => "store.question_answer",
                StoreEventHistogramBucketType.StoreReingestionCompleted => "store.reingestion.completed",
                StoreEventHistogramBucketType.StoreSearch => "store.search",
                StoreEventHistogramBucketType.StoreUpdated => "store.updated",
                StoreEventHistogramBucketType.StoreWebSearch => "store.web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreEventHistogramBucketType? ToEnum(string value)
        {
            return value switch
            {
                "api_key.created" => StoreEventHistogramBucketType.ApiKeyCreated,
                "api_key.deleted" => StoreEventHistogramBucketType.ApiKeyDeleted,
                "api_key.rerolled" => StoreEventHistogramBucketType.ApiKeyRerolled,
                "api_key.revoked" => StoreEventHistogramBucketType.ApiKeyRevoked,
                "api_key.updated" => StoreEventHistogramBucketType.ApiKeyUpdated,
                "auth.error" => StoreEventHistogramBucketType.AuthError,
                "auth.invalid_token" => StoreEventHistogramBucketType.AuthInvalidToken,
                "auth.success" => StoreEventHistogramBucketType.AuthSuccess,
                "data_source.connector.job.completed" => StoreEventHistogramBucketType.DataSourceConnectorJobCompleted,
                "data_source.created" => StoreEventHistogramBucketType.DataSourceCreated,
                "data_source.deleted" => StoreEventHistogramBucketType.DataSourceDeleted,
                "data_source.oauth2.authorized" => StoreEventHistogramBucketType.DataSourceOauth2Authorized,
                "data_source.oauth2.requested" => StoreEventHistogramBucketType.DataSourceOauth2Requested,
                "data_source.updated" => StoreEventHistogramBucketType.DataSourceUpdated,
                "extraction.job.cancelled" => StoreEventHistogramBucketType.ExtractionJobCancelled,
                "extraction.job.completed" => StoreEventHistogramBucketType.ExtractionJobCompleted,
                "extraction.job.created" => StoreEventHistogramBucketType.ExtractionJobCreated,
                "extraction.job.deleted" => StoreEventHistogramBucketType.ExtractionJobDeleted,
                "file.deleted" => StoreEventHistogramBucketType.FileDeleted,
                "file.downloaded" => StoreEventHistogramBucketType.FileDownloaded,
                "file.updated" => StoreEventHistogramBucketType.FileUpdated,
                "file.uploaded" => StoreEventHistogramBucketType.FileUploaded,
                "inference.embeddings" => StoreEventHistogramBucketType.InferenceEmbeddings,
                "inference.reranking" => StoreEventHistogramBucketType.InferenceReranking,
                "internal_error" => StoreEventHistogramBucketType.InternalError,
                "model_request" => StoreEventHistogramBucketType.ModelRequest,
                "parsing.job.cancelled" => StoreEventHistogramBucketType.ParsingJobCancelled,
                "parsing.job.completed" => StoreEventHistogramBucketType.ParsingJobCompleted,
                "parsing.job.created" => StoreEventHistogramBucketType.ParsingJobCreated,
                "parsing.job.deleted" => StoreEventHistogramBucketType.ParsingJobDeleted,
                "store.created" => StoreEventHistogramBucketType.StoreCreated,
                "store.deleted" => StoreEventHistogramBucketType.StoreDeleted,
                "store.file.cancelled" => StoreEventHistogramBucketType.StoreFileCancelled,
                "store.file.completed" => StoreEventHistogramBucketType.StoreFileCompleted,
                "store.file.created" => StoreEventHistogramBucketType.StoreFileCreated,
                "store.file.deleted" => StoreEventHistogramBucketType.StoreFileDeleted,
                "store.file.search" => StoreEventHistogramBucketType.StoreFileSearch,
                "store.file.updated" => StoreEventHistogramBucketType.StoreFileUpdated,
                "store.question_answer" => StoreEventHistogramBucketType.StoreQuestionAnswer,
                "store.reingestion.completed" => StoreEventHistogramBucketType.StoreReingestionCompleted,
                "store.search" => StoreEventHistogramBucketType.StoreSearch,
                "store.updated" => StoreEventHistogramBucketType.StoreUpdated,
                "store.web_search" => StoreEventHistogramBucketType.StoreWebSearch,
                _ => null,
            };
        }
    }
}