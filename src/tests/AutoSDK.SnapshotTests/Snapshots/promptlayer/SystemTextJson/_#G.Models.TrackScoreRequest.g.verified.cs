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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestId { get; set; }

        /// <summary>
        /// The score you would like to give to this request (0 - 100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Score { get; set; }

        /// <summary>
        /// A name for this request score. If not provided, the score will be tracked as `default`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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