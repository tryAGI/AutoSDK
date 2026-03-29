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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public double? Ts { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        public double? EndTs { get; set; }

        /// <summary>
        /// Speaker ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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