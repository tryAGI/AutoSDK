//HintName: G.Models.FunctionCallItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A function call initiated by the model
    /// </summary>
    public sealed partial class FunctionCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionCallItemTypeJsonConverter))]
        public global::G.FunctionCallItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallStatusEnumJsonConverter))]
        public global::G.ToolCallStatusEnum? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        public FunctionCallItem(
            string callId,
            string name,
            string arguments,
            string id,
            global::G.FunctionCallItemType type,
            global::G.ToolCallStatusEnum? status)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItem" /> class.
        /// </summary>
        public FunctionCallItem()
        {
        }
    }
}