//HintName: G.Models.GetAgentWidgetRouteConversationSignature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An expiring token that enables a websocket conversation to start. These can be generated for an agent using the /v1/convai/conversation/get-signed-url endpoint
    /// </summary>
    public sealed partial class GetAgentWidgetRouteConversationSignature
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}