//HintName: G.Models.Prompt2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to a prompt template and its variables. <br/>
    /// [Learn more](/docs/guides/text?api-mode=responses#reusable-prompts).
    /// </summary>
    public sealed partial class Prompt2
    {
        /// <summary>
        /// The unique identifier of the prompt template to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Optional version of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Optional map of values to substitute in for variables in your<br/>
        /// prompt. The substitution values can either be strings, or other<br/>
        /// Response input types like images or files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the prompt template to use.
        /// </param>
        /// <param name="version">
        /// Optional version of the prompt template.
        /// </param>
        /// <param name="variables">
        /// Optional map of values to substitute in for variables in your<br/>
        /// prompt. The substitution values can either be strings, or other<br/>
        /// Response input types like images or files.
        /// </param>
        public Prompt2(
            string id,
            string? version,
            object? variables)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2" /> class.
        /// </summary>
        public Prompt2()
        {
        }
    }
}