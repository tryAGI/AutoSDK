//HintName: G.Models.CreatePrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePrompt
    {
        /// <summary>
        /// Unique identifier for the project that the prompt belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Textual description of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The prompt, model, and its parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_data")]
        public global::G.PromptDataNullish? PromptData { get; set; }

        /// <summary>
        /// A list of tags for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        public global::G.FunctionTypeEnumNullish? FunctionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrompt" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the prompt belongs under
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="functionType"></param>
        public CreatePrompt(
            global::System.Guid projectId,
            string name,
            string slug,
            string? description,
            global::G.PromptDataNullish? promptData,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.FunctionTypeEnumNullish? functionType)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.PromptData = promptData;
            this.Tags = tags;
            this.FunctionType = functionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrompt" /> class.
        /// </summary>
        public CreatePrompt()
        {
        }
    }
}