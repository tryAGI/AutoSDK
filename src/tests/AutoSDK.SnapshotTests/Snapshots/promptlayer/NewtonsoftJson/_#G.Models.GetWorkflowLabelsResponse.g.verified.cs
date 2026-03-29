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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWorkflowLabelsResponseReleaseLabel> ReleaseLabels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowLabelsResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="releaseLabels"></param>
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