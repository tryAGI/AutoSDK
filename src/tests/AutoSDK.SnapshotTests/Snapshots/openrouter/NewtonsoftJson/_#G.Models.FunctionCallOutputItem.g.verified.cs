//HintName: G.Models.FunctionCallOutputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output from a function call execution
    /// </summary>
    public sealed partial class FunctionCallOutputItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionCallOutputItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionCallOutputItemOutput Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ToolCallStatusEnum? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public FunctionCallOutputItem(
            string callId,
            global::G.FunctionCallOutputItemOutput output,
            global::G.FunctionCallOutputItemType type,
            string? id,
            global::G.ToolCallStatusEnum? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItem" /> class.
        /// </summary>
        public FunctionCallOutputItem()
        {
        }
    }
}