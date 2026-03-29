//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="signature"></param>
        /// <param name="type"></param>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1(
            string text,
            string? signature,
            global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1Type? type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Signature = signature;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1" /> class.
        /// </summary>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1()
        {
        }
    }
}