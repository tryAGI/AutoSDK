//HintName: G.Models.GetNamespacePipelineReleaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespacePipelineReleaseResponse contains the requested pipeline release.
    /// </summary>
    public sealed partial class GetNamespacePipelineReleaseResponse
    {
        /// <summary>
        /// The pipeline release resource.<br/>
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
        /// Initializes a new instance of the <see cref="GetNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="release">
        /// The pipeline release resource.<br/>
        /// Included only in responses
        /// </param>
        public GetNamespacePipelineReleaseResponse(
            global::G.PipelineRelease? release)
        {
            this.Release = release;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public GetNamespacePipelineReleaseResponse()
        {
        }
    }
}