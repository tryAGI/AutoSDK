//HintName: G.Models.ScoredStoreFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a scored store file.
    /// </summary>
    public sealed partial class ScoredStoreFile
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Optional file metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// External identifier for this file in the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Processing status of the file<br/>
        /// Default Value: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.StoreFileStatus? Status { get; set; }

        /// <summary>
        /// Last error message if processing failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error")]
        public object? LastError { get; set; }

        /// <summary>
        /// ID of the containing store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// Timestamp of store file creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Version number of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Storage usage in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_bytes")]
        public long? UsageBytes { get; set; }

        /// <summary>
        /// Storage usage in tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_tokens")]
        public int? UsageTokens { get; set; }

        /// <summary>
        /// Configuration for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.StoreFileConfig2? Config { get; set; }

        /// <summary>
        /// Type of the object<br/>
        /// Default Value: store.file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Array of scored file chunks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks")]
        public global::System.Collections.Generic.IList<global::G.ChunksVariant1Item>? Chunks { get; set; }

        /// <summary>
        /// score of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredStoreFile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file
        /// </param>
        /// <param name="storeId">
        /// ID of the containing store
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of store file creation
        /// </param>
        /// <param name="score">
        /// score of the file
        /// </param>
        /// <param name="filename">
        /// Name of the file
        /// </param>
        /// <param name="metadata">
        /// Optional file metadata
        /// </param>
        /// <param name="externalId">
        /// External identifier for this file in the store
        /// </param>
        /// <param name="status">
        /// Processing status of the file<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="lastError">
        /// Last error message if processing failed
        /// </param>
        /// <param name="version">
        /// Version number of the file
        /// </param>
        /// <param name="usageBytes">
        /// Storage usage in bytes
        /// </param>
        /// <param name="usageTokens">
        /// Storage usage in tokens
        /// </param>
        /// <param name="config">
        /// Configuration for the file
        /// </param>
        /// <param name="object">
        /// Type of the object<br/>
        /// Default Value: store.file
        /// </param>
        /// <param name="chunks">
        /// Array of scored file chunks
        /// </param>
        public ScoredStoreFile(
            string id,
            string storeId,
            global::System.DateTime createdAt,
            double score,
            string? filename,
            object? metadata,
            string? externalId,
            global::G.StoreFileStatus? status,
            object? lastError,
            int? version,
            long? usageBytes,
            int? usageTokens,
            global::G.StoreFileConfig2? config,
            string? @object,
            global::System.Collections.Generic.IList<global::G.ChunksVariant1Item>? chunks)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.Metadata = metadata;
            this.ExternalId = externalId;
            this.Status = status;
            this.LastError = lastError;
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.CreatedAt = createdAt;
            this.Version = version;
            this.UsageBytes = usageBytes;
            this.UsageTokens = usageTokens;
            this.Config = config;
            this.Object = @object;
            this.Chunks = chunks;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredStoreFile" /> class.
        /// </summary>
        public ScoredStoreFile()
        {
        }
    }
}