//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter))]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_return", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>> ToolReturn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter))]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolReturn"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="stdout"></param>
        /// <param name="stderr"></param>
        public EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1(
            string toolCallId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>> toolReturn,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status status,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type? type,
            global::System.Collections.Generic.IList<string>? stdout,
            global::System.Collections.Generic.IList<string>? stderr)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolReturn = toolReturn;
            this.Status = status;
            this.Stdout = stdout;
            this.Stderr = stderr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1()
        {
        }
    }
}