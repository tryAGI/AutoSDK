//HintName: G.Models.ResponseTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTool
    {
        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseToolTypeJsonConverter))]
        public global::G.ResponseToolType Type { get; set; }

        /// <summary>
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Describes the function's purpose. The model uses this to determine when to invoke the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters defined as a JSON Schema object. Refer to https://json-schema.org/understanding-json-schema/ for schema documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.FunctionParameters? Parameters { get; set; }

        /// <summary>
        /// Whether to enable strict schema adherence when generating the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
        /// <param name="description">
        /// Describes the function's purpose. The model uses this to determine when to invoke the function.
        /// </param>
        /// <param name="parameters">
        /// Function parameters defined as a JSON Schema object. Refer to https://json-schema.org/understanding-json-schema/ for schema documentation.
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence when generating the function call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTool(
            string name,
            global::G.ResponseToolType type,
            string? description,
            global::G.FunctionParameters? parameters,
            bool? strict)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTool" /> class.
        /// </summary>
        public ResponseTool()
        {
        }
    }
}