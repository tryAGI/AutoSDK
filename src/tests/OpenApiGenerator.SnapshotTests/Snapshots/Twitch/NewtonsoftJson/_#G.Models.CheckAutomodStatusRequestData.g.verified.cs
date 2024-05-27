//HintName: G.Models.CheckAutomodStatusRequestData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutomodStatusRequestData
    {
        /// <summary>
        /// A caller-defined ID used to correlate this message with the same message in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MsgId { get; set; } = default!;

        /// <summary>
        /// The message to check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string MsgText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}