//HintName: G.Models.PipelineFileCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a file that is associated with a pipeline.
    /// </summary>
    public sealed partial class PipelineFileCreate
    {
        /// <summary>
        /// The ID of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Custom metadata for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFileCreate" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata for the file
        /// </param>
        public PipelineFileCreate(
            global::System.Guid fileId,
            object? customMetadata)
        {
            this.FileId = fileId;
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFileCreate" /> class.
        /// </summary>
        public PipelineFileCreate()
        {
        }
    }
}