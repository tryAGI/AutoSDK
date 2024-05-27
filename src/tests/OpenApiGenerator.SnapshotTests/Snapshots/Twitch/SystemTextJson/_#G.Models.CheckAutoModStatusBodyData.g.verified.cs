//HintName: G.Models.CheckAutoModStatusBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutoModStatusBodyData
    {
        /// <summary>
        /// A caller-defined ID used to correlate this message with the same message in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MsgId { get; set; }

        /// <summary>
        /// The message to check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MsgText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}