//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tool information.
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction
    {
        /// <summary>
        /// The name of the function to be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of what the function does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunctionParameters? Parameters { get; set; }

        /// <summary>
        /// Whether to enable strict schema adherence when generating the function call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to be called.
        /// </param>
        /// <param name="description">
        /// A description of what the function does.
        /// </param>
        /// <param name="parameters">
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence when generating the function call.
        /// </param>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction(
            string? name,
            string? description,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunctionParameters? parameters,
            bool? strict)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction()
        {
        }
    }
}