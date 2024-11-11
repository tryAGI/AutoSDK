//HintName: G.Models.UpdateNamespacePipelineReleaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateNamespacePipelineReleaseResponse contains the updated pipeline release.
    /// </summary>
    public sealed partial class UpdateNamespacePipelineReleaseResponse
    {
        /// <summary>
        /// The updated pipeline release resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release")]
        public global::G.PipelineRelease? Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="release">
        /// The updated pipeline release resource.<br/>
        /// Included only in responses
        /// </param>
        public UpdateNamespacePipelineReleaseResponse(
            global::G.PipelineRelease? release)
        {
            this.Release = release;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public UpdateNamespacePipelineReleaseResponse()
        {
        }
    }
}