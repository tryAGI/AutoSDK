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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptVersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReleaseLabelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateLabelResponseReleaseLabel" /> class.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="releaseLabel"></param>
        /// <param name="releaseLabelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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