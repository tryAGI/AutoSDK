//HintName: G.Models.TopicDetectionSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds overall information on the topics detected.
    /// </summary>
    public sealed partial class TopicDetectionSummary
    {
        /// <summary>
        /// Holds the count of topics detected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall")]
        public global::System.Collections.Generic.Dictionary<string, int>? Overall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSummary" /> class.
        /// </summary>
        /// <param name="overall">
        /// Holds the count of topics detected.
        /// </param>
        public TopicDetectionSummary(
            global::System.Collections.Generic.Dictionary<string, int>? overall)
        {
            this.Overall = overall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSummary" /> class.
        /// </summary>
        public TopicDetectionSummary()
        {
        }
    }
}