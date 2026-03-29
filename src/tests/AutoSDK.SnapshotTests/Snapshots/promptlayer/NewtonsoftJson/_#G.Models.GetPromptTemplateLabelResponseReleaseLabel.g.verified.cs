//HintName: G.Models.GetPromptTemplateLabelResponseReleaseLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateLabelResponseReleaseLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptVersionNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleaseLabel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_label_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReleaseLabelId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateLabelResponseReleaseLabel" /> class.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="releaseLabel"></param>
        /// <param name="releaseLabelId"></param>
        public GetPromptTemplateLabelResponseReleaseLabel(
            int promptVersionId,
            int promptVersionNumber,
            string releaseLabel,
            int releaseLabelId)
        {
            this.PromptVersionId = promptVersionId;
            this.PromptVersionNumber = promptVersionNumber;
            this.ReleaseLabel = releaseLabel ?? throw new global::System.ArgumentNullException(nameof(releaseLabel));
            this.ReleaseLabelId = releaseLabelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateLabelResponseReleaseLabel" /> class.
        /// </summary>
        public GetPromptTemplateLabelResponseReleaseLabel()
        {
        }
    }
}