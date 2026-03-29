//HintName: G.Models.StoreCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a new store.
    /// </summary>
    public sealed partial class StoreCreateParams
    {
        /// <summary>
        /// Name for the new store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Optional expiration policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.ExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Store-level configuration defaults
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.StoreConfig2? Config { get; set; }

        /// <summary>
        /// Optional list of file IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).
        /// </param>
        /// <param name="description">
        /// Description of the store
        /// </param>
        /// <param name="isPublic">
        /// Whether the store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="config">
        /// Store-level configuration defaults
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs
        /// </param>
        public StoreCreateParams(
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata,
            global::G.StoreConfig2? config,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds)
        {
            this.Name = name;
            this.Description = description;
            this.IsPublic = isPublic;
            this.ExpiresAfter = expiresAfter;
            this.Metadata = metadata;
            this.Config = config;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCreateParams" /> class.
        /// </summary>
        public StoreCreateParams()
        {
        }
    }
}