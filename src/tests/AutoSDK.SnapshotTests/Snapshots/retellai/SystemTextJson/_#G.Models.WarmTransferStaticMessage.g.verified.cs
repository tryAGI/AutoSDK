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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WarmTransferStaticMessageTypeJsonConverter))]
        public global::G.WarmTransferStaticMessageType? Type { get; set; }

        /// <summary>
        /// The static message to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: You can take it from here.
        /// </summary>
        /// <example>You can take it from here.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WarmTransferStaticMessage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// The static message to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: You can take it from here.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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