//HintName: G.Models.AddIceCandidateRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddIceCandidateRequest2
    {
        /// <summary>
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIceCandidateRequest2" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        public AddIceCandidateRequest2(
            string? sessionId)
        {
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIceCandidateRequest2" /> class.
        /// </summary>
        public AddIceCandidateRequest2()
        {
        }
    }
}