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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionCallOutputItemTypeJsonConverter))]
        public global::G.FunctionCallOutputItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionCallOutputItemOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionCallOutputItemOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallStatusEnumJsonConverter))]
        public global::G.ToolCallStatusEnum? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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