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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>> Content { get; set; }

        /// <summary>
        /// The JSON schema to use for extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JsonSchema { get; set; }

        /// <summary>
        /// Additional instructions for the extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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