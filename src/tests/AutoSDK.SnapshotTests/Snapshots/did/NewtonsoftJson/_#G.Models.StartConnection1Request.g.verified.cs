//HintName: G.Models.StartConnection1Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConnection1Request
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
        public global::G.StartConnection1RequestAnswer Answer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnection1Request" /> class.
        /// </summary>
        /// <param name="answer">
        /// Jsep answer object used to create a peer connection
        /// </param>
        /// <param name="sessionId">
        /// Session identifier information, should be returned in the body of all streaming requests (from the response<br/>
        /// of the POST /streams)
        /// </param>
        public StartConnection1Request(
            global::G.StartConnection1RequestAnswer answer,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConnection1Request" /> class.
        /// </summary>
        public StartConnection1Request()
        {
        }
    }
}