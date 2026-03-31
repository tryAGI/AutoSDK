//HintName: G.Models.InitStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitStreamResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Id of the stream - should be returned as *path parameter* in all streaming request to the same stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Jsep offer object used to create a peer connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsep")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InitStreamResponseJsep Jsep { get; set; }

        /// <summary>
        /// ICE servers used to create a peer connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ice_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InitStreamResponseIceServer> IceServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the stream - should be returned as *path parameter* in all streaming request to the same stream
        /// </param>
        /// <param name="jsep">
        /// Jsep offer object used to create a peer connection
        /// </param>
        /// <param name="iceServers">
        /// ICE servers used to create a peer connection
        /// </param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitStreamResponse(
            string id,
            global::G.InitStreamResponseJsep jsep,
            global::System.Collections.Generic.IList<global::G.InitStreamResponseIceServer> iceServers,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Jsep = jsep ?? throw new global::System.ArgumentNullException(nameof(jsep));
            this.IceServers = iceServers ?? throw new global::System.ArgumentNullException(nameof(iceServers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamResponse" /> class.
        /// </summary>
        public InitStreamResponse()
        {
        }
    }
}