//HintName: G.Models.LogprobsResultCandidate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Candidate for the logprobs token and score.
    /// </summary>
    public sealed partial class LogprobsResultCandidate
    {
        /// <summary>
        /// The candidate’s token string value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The candidate’s token id value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenId")]
        public int? TokenId { get; set; }

        /// <summary>
        /// The candidate's log probability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logProbability")]
        public float? LogProbability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsResultCandidate" /> class.
        /// </summary>
        /// <param name="token">
        /// The candidate’s token string value.
        /// </param>
        /// <param name="tokenId">
        /// The candidate’s token id value.
        /// </param>
        /// <param name="logProbability">
        /// The candidate's log probability.
        /// </param>
        public LogprobsResultCandidate(
            string? token,
            int? tokenId,
            float? logProbability)
        {
            this.Token = token;
            this.TokenId = tokenId;
            this.LogProbability = logProbability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsResultCandidate" /> class.
        /// </summary>
        public LogprobsResultCandidate()
        {
        }
    }
}