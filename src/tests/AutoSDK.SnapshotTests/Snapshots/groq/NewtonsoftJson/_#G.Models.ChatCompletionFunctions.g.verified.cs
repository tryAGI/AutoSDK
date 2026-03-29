//HintName: G.Models.ChatCompletionFunctions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ChatCompletionFunctions
    {
        /// <summary>
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Function parameters defined as a JSON Schema object. Refer to https://json-schema.org/understanding-json-schema/ for schema documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.FunctionParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctions" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="description">
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </param>
        /// <param name="parameters">
        /// Function parameters defined as a JSON Schema object. Refer to https://json-schema.org/understanding-json-schema/ for schema documentation.
        /// </param>
        public ChatCompletionFunctions(
            string name,
            string? description,
            global::G.FunctionParameters? parameters)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctions" /> class.
        /// </summary>
        public ChatCompletionFunctions()
        {
        }
    }
}