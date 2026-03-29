//HintName: G.Models.SentimentAnalysisResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentAnalysisResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sentiment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion", Required = global::Newtonsoft.Json.Required.Always)]
        public string Emotion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel", Required = global::Newtonsoft.Json.Required.Always)]
        public double Channel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        /// <param name="sentiment"></param>
        /// <param name="emotion"></param>
        /// <param name="text"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="channel"></param>
        public SentimentAnalysisResult(
            string sentiment,
            string emotion,
            string text,
            double start,
            double end,
            double channel)
        {
            this.Sentiment = sentiment ?? throw new global::System.ArgumentNullException(nameof(sentiment));
            this.Emotion = emotion ?? throw new global::System.ArgumentNullException(nameof(emotion));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        public SentimentAnalysisResult()
        {
        }
    }
}