//HintName: G.Models.StartConnectionRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConnectionRequest2
    {
        /// <summary>
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Jsep answer object used to create a peer connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StartConnectionRequestAnswer2 Answer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequest2" /> class.
        /// </summary>
        /// <param name="answer">
        /// Jsep answer object used to create a peer connection
        /// </param>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        public StartConnectionRequest2(
            global::G.StartConnectionRequestAnswer2 answer,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnectionRequest2" /> class.
        /// </summary>
        public StartConnectionRequest2()
        {
        }
    }
}