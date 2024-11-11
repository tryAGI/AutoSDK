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
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public global::G.PipelineRelease? Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="release">
        /// The pipeline release resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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