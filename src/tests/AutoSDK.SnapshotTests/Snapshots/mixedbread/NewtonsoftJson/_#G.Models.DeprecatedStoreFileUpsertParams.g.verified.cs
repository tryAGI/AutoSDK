//HintName: G.Models.DeprecatedStoreFileUpsertParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeprecatedStoreFileUpsertParams
    {
        /// <summary>
        /// Optional metadata for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Configuration for adding the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.StoreFileConfig2? Config { get; set; }

        /// <summary>
        /// External identifier for this file in the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// If true, overwrite an existing file with the same external_id<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// ID of the file to add
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Strategy for adding the file. This field is deprecated. Please use the top-level 'config' field instead. If this is provided, it will override the top-level 'config' field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimental")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.StoreFileConfig2? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedStoreFileUpsertParams" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the file to add
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the file
        /// </param>
        /// <param name="config">
        /// Configuration for adding the file
        /// </param>
        /// <param name="externalId">
        /// External identifier for this file in the store
        /// </param>
        /// <param name="overwrite">
        /// If true, overwrite an existing file with the same external_id<br/>
        /// Default Value: true
        /// </param>
        public DeprecatedStoreFileUpsertParams(
            global::System.Guid fileId,
            object? metadata,
            global::G.StoreFileConfig2? config,
            string? externalId,
            bool? overwrite)
        {
            this.Metadata = metadata;
            this.Config = config;
            this.ExternalId = externalId;
            this.Overwrite = overwrite;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedStoreFileUpsertParams" /> class.
        /// </summary>
        public DeprecatedStoreFileUpsertParams()
        {
        }
    }
}