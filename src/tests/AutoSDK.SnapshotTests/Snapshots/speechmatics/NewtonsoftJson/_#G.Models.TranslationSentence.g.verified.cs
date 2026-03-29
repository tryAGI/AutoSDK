//HintName: G.Models.TranslationSentence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationSentence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public float? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public float? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationSentence" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="content"></param>
        /// <param name="speaker"></param>
        /// <param name="channel"></param>
        public TranslationSentence(
            float? startTime,
            float? endTime,
            string? content,
            string? speaker,
            string? channel)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Content = content;
            this.Speaker = speaker;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationSentence" /> class.
        /// </summary>
        public TranslationSentence()
        {
        }
    }
}