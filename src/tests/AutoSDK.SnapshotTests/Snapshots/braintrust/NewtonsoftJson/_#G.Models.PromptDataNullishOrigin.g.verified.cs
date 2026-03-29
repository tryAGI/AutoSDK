//HintName: G.Models.PromptDataNullishOrigin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDataNullishOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version")]
        public string? PromptVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishOrigin" /> class.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="projectId"></param>
        /// <param name="promptVersion"></param>
        public PromptDataNullishOrigin(
            string? promptId,
            string? projectId,
            string? promptVersion)
        {
            this.PromptId = promptId;
            this.ProjectId = projectId;
            this.PromptVersion = promptVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishOrigin" /> class.
        /// </summary>
        public PromptDataNullishOrigin()
        {
        }
    }
}