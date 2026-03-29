//HintName: G.Models.PipelineFileUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a pipeline file.
    /// </summary>
    public sealed partial class PipelineFileUpdate
    {
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
        /// Initializes a new instance of the <see cref="PipelineFileUpdate" /> class.
        /// </summary>
        /// <param name="customMetadata">
        /// Custom metadata for the file
        /// </param>
        public PipelineFileUpdate(
            object? customMetadata)
        {
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFileUpdate" /> class.
        /// </summary>
        public PipelineFileUpdate()
        {
        }
    }
}