//HintName: G.Models.PatchFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchFunction
    {
        /// <summary>
        /// Name of the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The prompt, model, and its parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_data")]
        public global::G.PromptDataNullish? PromptData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishJsonConverter))]
        public global::G.FunctionDataNullish? FunctionData { get; set; }

        /// <summary>
        /// A list of tags for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="functionData"></param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchFunction(
            string? name,
            string? description,
            global::G.PromptDataNullish? promptData,
            global::G.FunctionDataNullish? functionData,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Description = description;
            this.PromptData = promptData;
            this.FunctionData = functionData;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFunction" /> class.
        /// </summary>
        public PatchFunction()
        {
        }
    }
}