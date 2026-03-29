//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing the tool to be chosen
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// An object containing the name of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1Function? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        /// <param name="function">
        /// An object containing the name of the function
        /// </param>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1(
            string? type,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1Function? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1()
        {
        }
    }
}