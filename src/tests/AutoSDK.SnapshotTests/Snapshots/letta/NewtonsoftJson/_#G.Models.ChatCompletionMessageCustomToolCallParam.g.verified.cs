//HintName: G.Models.ChatCompletionMessageCustomToolCallParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A call to a custom tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageCustomToolCallParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The custom tool that the model called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomInput Custom { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCallParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="custom">
        /// The custom tool that the model called.
        /// </param>
        /// <param name="type"></param>
        public ChatCompletionMessageCustomToolCallParam(
            string id,
            global::G.CustomInput custom,
            string type = "custom")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCallParam" /> class.
        /// </summary>
        public ChatCompletionMessageCustomToolCallParam()
        {
        }
    }
}