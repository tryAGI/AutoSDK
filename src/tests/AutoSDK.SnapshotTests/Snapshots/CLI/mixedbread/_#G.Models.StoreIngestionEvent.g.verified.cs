//HintName: G.Models.StoreIngestionEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an ingestion event in a vector store.
    /// </summary>
    public sealed partial class StoreIngestionEvent
    {
        /// <summary>
        /// Unique identifier for the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Default Value: ingestion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the vector store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid StoreId { get; set; }

        /// <summary>
        /// ID of the vector store file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreFileId { get; set; }

        /// <summary>
        /// Total time taken to ingest the file, including queue time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalTime { get; set; }

        /// <summary>
        /// Time spent in the queue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueueTime { get; set; }

        /// <summary>
        /// Time taken to ingest the file, excluding queue time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestion_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IngestionTime { get; set; }

        /// <summary>
        /// Number of chunks ingested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkCount { get; set; }

        /// <summary>
        /// Whether contextualization was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextualization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Contextualization { get; set; }

        /// <summary>
        /// Strategy used to ingest the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StoreFileParsingStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StoreFileParsingStrategy Mode { get; set; }

        /// <summary>
        /// Name of the file if the event is tied to a file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreIngestionEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the event
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created
        /// </param>
        /// <param name="storeId">
        /// ID of the vector store
        /// </param>
        /// <param name="storeFileId">
        /// ID of the vector store file
        /// </param>
        /// <param name="totalTime">
        /// Total time taken to ingest the file, including queue time
        /// </param>
        /// <param name="queueTime">
        /// Time spent in the queue
        /// </param>
        /// <param name="ingestionTime">
        /// Time taken to ingest the file, excluding queue time
        /// </param>
        /// <param name="chunkCount">
        /// Number of chunks ingested
        /// </param>
        /// <param name="contextualization">
        /// Whether contextualization was used
        /// </param>
        /// <param name="mode">
        /// Strategy used to ingest the file
        /// </param>
        /// <param name="type">
        /// Default Value: ingestion
        /// </param>
        /// <param name="filename">
        /// Name of the file if the event is tied to a file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreIngestionEvent(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Guid storeId,
            string storeFileId,
            string totalTime,
            string queueTime,
            string ingestionTime,
            int chunkCount,
            bool contextualization,
            global::G.StoreFileParsingStrategy mode,
            string? type,
            string? filename)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.StoreId = storeId;
            this.StoreFileId = storeFileId ?? throw new global::System.ArgumentNullException(nameof(storeFileId));
            this.TotalTime = totalTime ?? throw new global::System.ArgumentNullException(nameof(totalTime));
            this.QueueTime = queueTime ?? throw new global::System.ArgumentNullException(nameof(queueTime));
            this.IngestionTime = ingestionTime ?? throw new global::System.ArgumentNullException(nameof(ingestionTime));
            this.ChunkCount = chunkCount;
            this.Contextualization = contextualization;
            this.Mode = mode;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreIngestionEvent" /> class.
        /// </summary>
        public StoreIngestionEvent()
        {
        }
    }
}