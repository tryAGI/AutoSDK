//HintName: G.Models.Prompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A prompt that can be used with a LLM. A prompt is the template that is used to render<br/>
    /// the text sent to the LLM. It also contains various default model settings such as<br/>
    /// temperature.
    /// </summary>
    public sealed partial class Prompt
    {
        /// <summary>
        /// The ID of the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the prompt. This is used as the `prompt_name` in a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the prompt is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the prompt.
        /// </param>
        /// <param name="name">
        /// Name of the prompt. This is used as the `prompt_name` in a query.
        /// </param>
        /// <param name="description">
        /// The description of the prompt.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the prompt is enabled.
        /// </param>
        /// <param name="default">
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt(
            string? id,
            string? name,
            string? description,
            bool? enabled,
            bool? @default)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        public Prompt()
        {
        }
    }
}