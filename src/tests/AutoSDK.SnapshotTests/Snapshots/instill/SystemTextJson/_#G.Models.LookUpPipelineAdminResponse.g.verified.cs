//HintName: G.Models.LookUpPipelineAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LookUpPipelineAdminResponse contains the requested pipeline.
    /// </summary>
    public sealed partial class LookUpPipelineAdminResponse
    {
        /// <summary>
        /// The requested pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::G.Pipeline? Pipeline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpPipelineAdminResponse" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// The requested pipeline.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LookUpPipelineAdminResponse(
            global::G.Pipeline? pipeline)
        {
            this.Pipeline = pipeline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpPipelineAdminResponse" /> class.
        /// </summary>
        public LookUpPipelineAdminResponse()
        {
        }
    }
}