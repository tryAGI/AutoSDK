//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.EnvironmentsSendMessageRequestMessageVariant1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientMessageId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="clientMessageId"></param>
        /// <param name="role"></param>
        /// <param name="otid"></param>
        public EnvironmentsSendMessageRequestMessageVariant1(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>> content,
            string clientMessageId,
            global::G.EnvironmentsSendMessageRequestMessageVariant1Role role,
            string? otid)
        {
            this.Role = role;
            this.Content = content;
            this.ClientMessageId = clientMessageId ?? throw new global::System.ArgumentNullException(nameof(clientMessageId));
            this.Otid = otid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant1()
        {
        }
    }
}