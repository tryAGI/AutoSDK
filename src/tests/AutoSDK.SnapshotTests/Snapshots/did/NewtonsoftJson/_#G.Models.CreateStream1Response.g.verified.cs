//HintName: G.Models.CreateStream1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStream1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Id of the stream - should be returned as *path parameter* in all streaming request to the same stream
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Jsep offer object used to create a peer connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jsep", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateStream1ResponseJsep Jsep { get; set; } = default!;

        /// <summary>
        /// ICE servers used to create a peer connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ice_servers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateStream1ResponseIceServer> IceServers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1Response" /> class.
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
        public CreateStream1Response(
            string id,
            global::G.CreateStream1ResponseJsep jsep,
            global::System.Collections.Generic.IList<global::G.CreateStream1ResponseIceServer> iceServers,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Jsep = jsep ?? throw new global::System.ArgumentNullException(nameof(jsep));
            this.IceServers = iceServers ?? throw new global::System.ArgumentNullException(nameof(iceServers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1Response" /> class.
        /// </summary>
        public CreateStream1Response()
        {
        }
    }
}