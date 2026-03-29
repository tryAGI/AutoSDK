//HintName: G.Models.GetWorkflowLabelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowLabelsResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetWorkflowLabelsResponseReleaseLabel> ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowLabelsResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="releaseLabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowLabelsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::G.GetWorkflowLabelsResponseReleaseLabel> releaseLabels)
        {
            this.Success = success;
            this.ReleaseLabels = releaseLabels ?? throw new global::System.ArgumentNullException(nameof(releaseLabels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowLabelsResponse" /> class.
        /// </summary>
        public GetWorkflowLabelsResponse()
        {
        }
    }
}