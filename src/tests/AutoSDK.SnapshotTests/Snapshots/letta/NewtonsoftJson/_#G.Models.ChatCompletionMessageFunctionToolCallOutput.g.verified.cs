//HintName: G.Models.ChatCompletionMessageFunctionToolCallOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A call to a function tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageFunctionToolCallOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The function that the model called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionOutput Function { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"function"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCallOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="function">
        /// The function that the model called.
        /// </param>
        /// <param name="type"></param>
        public ChatCompletionMessageFunctionToolCallOutput(
            string id,
            global::G.FunctionOutput function,
            string type = "function")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCallOutput" /> class.
        /// </summary>
        public ChatCompletionMessageFunctionToolCallOutput()
        {
        }
    }
}