//HintName: G.Models.ConversationHistoryErrorCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryErrorCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryErrorCommonModel" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="reason"></param>
        public ConversationHistoryErrorCommonModel(
            int code,
            string? reason)
        {
            this.Code = code;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryErrorCommonModel" /> class.
        /// </summary>
        public ConversationHistoryErrorCommonModel()
        {
        }
    }
}