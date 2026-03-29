//HintName: G.Models.TrackScoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackScoreRequest
    {
        /// <summary>
        /// The `request_id` from tracking a request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; } = default!;

        /// <summary>
        /// The score you would like to give to this request (0 - 100).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public int Score { get; set; } = default!;

        /// <summary>
        /// A name for this request score. If not provided, the score will be tracked as `default`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackScoreRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The `request_id` from tracking a request.
        /// </param>
        /// <param name="score">
        /// The score you would like to give to this request (0 - 100).
        /// </param>
        /// <param name="name">
        /// A name for this request score. If not provided, the score will be tracked as `default`.
        /// </param>
        public TrackScoreRequest(
            int requestId,
            int score,
            string? name)
        {
            this.RequestId = requestId;
            this.Score = score;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackScoreRequest" /> class.
        /// </summary>
        public TrackScoreRequest()
        {
        }
    }
}