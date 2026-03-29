//HintName: G.Models.ExpressiveAgentSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class ExpressiveAgentSentiment
    {
        /// <summary>
        /// The id of the expression
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::Newtonsoft.Json.JsonProperty("sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExpressiveAgentSentimentSentiment Sentiment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAgentSentiment" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expression
        /// </param>
        /// <param name="sentiment">
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </param>
        public ExpressiveAgentSentiment(
            string id,
            global::G.ExpressiveAgentSentimentSentiment sentiment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Sentiment = sentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAgentSentiment" /> class.
        /// </summary>
        public ExpressiveAgentSentiment()
        {
        }
    }
}