//HintName: G.Models.CreateNamespacePipelineReleaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateNamespacePipelineReleaseResponse contains the created release.
    /// </summary>
    public sealed partial class CreateNamespacePipelineReleaseResponse
    {
        /// <summary>
        /// The created pipeline release object.<br/>
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
        /// Initializes a new instance of the <see cref="CreateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="release">
        /// The created pipeline release object.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacePipelineReleaseResponse(
            global::G.PipelineRelease? release)
        {
            this.Release = release;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public CreateNamespacePipelineReleaseResponse()
        {
        }
    }
}