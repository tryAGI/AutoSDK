//HintName: G.Models.PatchPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchPrompt
    {
        /// <summary>
        /// Name of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique identifier for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPrompt" /> class.
        /// </summary>
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
        public PatchPrompt(
            string? name,
            string? slug,
            string? description,
            global::G.PromptDataNullish? promptData,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
            this.PromptData = promptData;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPrompt" /> class.
        /// </summary>
        public PatchPrompt()
        {
        }
    }
}