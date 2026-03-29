//HintName: G.Models.WarmTransferStaticMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WarmTransferStaticMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WarmTransferStaticMessageType? Type { get; set; }

        /// <summary>
        /// The static message to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: You can take it from here.
        /// </summary>
        /// <example>You can take it from here.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WarmTransferStaticMessage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// The static message to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: You can take it from here.
        /// </param>
        public WarmTransferStaticMessage(
            global::G.WarmTransferStaticMessageType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarmTransferStaticMessage" /> class.
        /// </summary>
        public WarmTransferStaticMessage()
        {
        }
    }
}