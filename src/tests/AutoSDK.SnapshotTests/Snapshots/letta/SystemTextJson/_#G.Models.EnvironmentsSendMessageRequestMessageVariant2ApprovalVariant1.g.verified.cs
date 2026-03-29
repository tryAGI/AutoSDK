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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter))]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_return")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>> ToolReturn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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