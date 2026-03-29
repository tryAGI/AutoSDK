//HintName: G.Models.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function that the model called.
    /// </summary>
    public sealed partial class OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
        public OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction" /> class.
        /// </summary>
        public OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction()
        {
        }
    }
}