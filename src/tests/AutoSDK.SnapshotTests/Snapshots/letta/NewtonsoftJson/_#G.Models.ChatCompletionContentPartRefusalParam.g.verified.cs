//HintName: G.Models.ChatCompletionContentPartRefusalParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartRefusalParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refusal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"refusal"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "refusal";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartRefusalParam" /> class.
        /// </summary>
        /// <param name="refusal"></param>
        /// <param name="type"></param>
        public ChatCompletionContentPartRefusalParam(
            string refusal,
            string type = "refusal")
        {
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartRefusalParam" /> class.
        /// </summary>
        public ChatCompletionContentPartRefusalParam()
        {
        }
    }
}