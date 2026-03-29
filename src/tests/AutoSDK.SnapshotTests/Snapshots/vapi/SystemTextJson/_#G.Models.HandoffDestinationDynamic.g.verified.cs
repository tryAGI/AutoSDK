//HintName: G.Models.HandoffDestinationDynamic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandoffDestinationDynamic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HandoffDestinationDynamicTypeJsonConverter))]
        public global::G.HandoffDestinationDynamicType Type { get; set; }

        /// <summary>
        /// This is where Vapi will send the handoff-destination-request webhook in a dynamic handoff.<br/>
        /// The order of precedence is:<br/>
        /// 1. tool.server.url<br/>
        /// 2. assistant.server.url<br/>
        /// 3. phoneNumber.server.url<br/>
        /// 4. org.server.url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationDynamic" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="server">
        /// This is where Vapi will send the handoff-destination-request webhook in a dynamic handoff.<br/>
        /// The order of precedence is:<br/>
        /// 1. tool.server.url<br/>
        /// 2. assistant.server.url<br/>
        /// 3. phoneNumber.server.url<br/>
        /// 4. org.server.url
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandoffDestinationDynamic(
            global::G.HandoffDestinationDynamicType type,
            global::G.Server? server,
            string? description)
        {
            this.Type = type;
            this.Server = server;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationDynamic" /> class.
        /// </summary>
        public HandoffDestinationDynamic()
        {
        }
    }
}