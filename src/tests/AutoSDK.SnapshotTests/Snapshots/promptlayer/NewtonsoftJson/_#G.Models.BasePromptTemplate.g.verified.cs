//HintName: G.Models.BasePromptTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasePromptTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The ID of the folder to publish the prompt template into. If not provided, the prompt will be published to the root level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePromptTemplate" /> class.
        /// </summary>
        /// <param name="promptName"></param>
        /// <param name="tags">
        /// Default Value: []
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to publish the prompt template into. If not provided, the prompt will be published to the root level.
        /// </param>
        public BasePromptTemplate(
            string promptName,
            global::System.Collections.Generic.IList<string>? tags,
            int? folderId)
        {
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.Tags = tags;
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePromptTemplate" /> class.
        /// </summary>
        public BasePromptTemplate()
        {
        }
    }
}