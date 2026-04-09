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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: ingestion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid StoreId { get; set; } = default!;

        /// <summary>
        /// ID of the vector store file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreFileId { get; set; } = default!;

        /// <summary>
        /// Total time taken to ingest the file, including queue time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_time", Required = global::Newtonsoft.Json.Required.Always)]
        public string TotalTime { get; set; } = default!;

        /// <summary>
        /// Time spent in the queue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_time", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueueTime { get; set; } = default!;

        /// <summary>
        /// Time taken to ingest the file, excluding queue time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ingestion_time", Required = global::Newtonsoft.Json.Required.Always)]
        public string IngestionTime { get; set; } = default!;

        /// <summary>
        /// Number of chunks ingested
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkCount { get; set; } = default!;

        /// <summary>
        /// Whether contextualization was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextualization", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Contextualization { get; set; } = default!;

        /// <summary>
        /// Strategy used to ingest the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StoreFileParsingStrategyJsonConverter))]
        public global::G.StoreFileParsingStrategy Mode { get; set; } = default!;

        /// <summary>
        /// Name of the file if the event is tied to a file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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