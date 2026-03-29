//HintName: G.Models.ServerMessageStatusUpdateInboundPhoneCallDebuggingArtifacts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.<br/>
    /// This will include any errors related to the "assistant-request" if one was made.
    /// </summary>
    public sealed partial class ServerMessageStatusUpdateInboundPhoneCallDebuggingArtifacts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}