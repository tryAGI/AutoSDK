//HintName: G.Models.GetPromptTemplateLabelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateLabelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPromptTemplateLabelResponseReleaseLabel> ReleaseLabels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateLabelResponse" /> class.
        /// </summary>
        /// <param name="releaseLabels"></param>
        public GetPromptTemplateLabelResponse(
            global::System.Collections.Generic.IList<global::G.GetPromptTemplateLabelResponseReleaseLabel> releaseLabels)
        {
            this.ReleaseLabels = releaseLabels ?? throw new global::System.ArgumentNullException(nameof(releaseLabels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateLabelResponse" /> class.
        /// </summary>
        public GetPromptTemplateLabelResponse()
        {
        }
    }
}