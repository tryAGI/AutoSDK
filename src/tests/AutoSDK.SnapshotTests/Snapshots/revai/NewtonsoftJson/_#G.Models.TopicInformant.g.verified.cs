//HintName: G.Models.TopicInformant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicInformant
    {
        /// <summary>
        /// Text content mentioning the topic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ts")]
        public double? Ts { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_ts")]
        public double? EndTs { get; set; }

        /// <summary>
        /// Speaker ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicInformant" /> class.
        /// </summary>
        /// <param name="content">
        /// Text content mentioning the topic
        /// </param>
        /// <param name="ts">
        /// Start timestamp in seconds
        /// </param>
        /// <param name="endTs">
        /// End timestamp in seconds
        /// </param>
        /// <param name="speaker">
        /// Speaker ID
        /// </param>
        public TopicInformant(
            string? content,
            double? ts,
            double? endTs,
            int? speaker)
        {
            this.Content = content;
            this.Ts = ts;
            this.EndTs = endTs;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicInformant" /> class.
        /// </summary>
        public TopicInformant()
        {
        }
    }
}