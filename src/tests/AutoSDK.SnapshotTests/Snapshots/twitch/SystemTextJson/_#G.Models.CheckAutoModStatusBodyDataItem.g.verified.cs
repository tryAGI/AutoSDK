//HintName: G.Models.CheckAutoModStatusBodyDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutoModStatusBodyDataItem
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

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBodyDataItem" /> class.
        /// </summary>
        /// <param name="msgId">
        /// A caller-defined ID used to correlate this message with the same message in the response.
        /// </param>
        /// <param name="msgText">
        /// The message to check.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckAutoModStatusBodyDataItem(
            string msgId,
            string msgText)
        {
            this.MsgId = msgId ?? throw new global::System.ArgumentNullException(nameof(msgId));
            this.MsgText = msgText ?? throw new global::System.ArgumentNullException(nameof(msgText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBodyDataItem" /> class.
        /// </summary>
        public CheckAutoModStatusBodyDataItem()
        {
        }
    }
}