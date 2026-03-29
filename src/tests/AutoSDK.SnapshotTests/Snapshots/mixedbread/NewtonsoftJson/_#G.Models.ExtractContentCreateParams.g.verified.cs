//HintName: G.Models.ExtractContentCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for extracting content using a schema.
    /// </summary>
    public sealed partial class ExtractContentCreateParams
    {
        /// <summary>
        /// The content to extract from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>> Content { get; set; } = default!;

        /// <summary>
        /// The JSON schema to use for extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional instructions for the extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractContentCreateParams" /> class.
        /// </summary>
        /// <param name="content">
        /// The content to extract from
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for extraction
        /// </param>
        /// <param name="instructions">
        /// Additional instructions for the extraction
        /// </param>
        public ExtractContentCreateParams(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>> content,
            object jsonSchema,
            string? instructions)
        {
            this.Content = content;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractContentCreateParams" /> class.
        /// </summary>
        public ExtractContentCreateParams()
        {
        }
    }
}