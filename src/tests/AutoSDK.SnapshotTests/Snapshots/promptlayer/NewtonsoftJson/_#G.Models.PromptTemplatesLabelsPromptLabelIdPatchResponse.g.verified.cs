//HintName: G.Models.PromptTemplatesLabelsPromptLabelIdPatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptTemplatesLabelsPromptLabelIdPatchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptVersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplatesLabelsPromptLabelIdPatchResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        public PromptTemplatesLabelsPromptLabelIdPatchResponse(
            global::System.DateTime createdAt,
            int id,
            string name,
            int promptId,
            int promptVersionId)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PromptId = promptId;
            this.PromptVersionId = promptVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplatesLabelsPromptLabelIdPatchResponse" /> class.
        /// </summary>
        public PromptTemplatesLabelsPromptLabelIdPatchResponse()
        {
        }
    }
}