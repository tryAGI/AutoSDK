//HintName: G.Models.SentimentAnalysisResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the Sentiment Analysis model<br/>
    /// Example: {"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US.","start":250,"end":6350,"sentiment":"NEGATIVE","confidence":0.8181032538414001,"speaker":""}
    /// </summary>
    public sealed partial class SentimentAnalysisResult
    {
        /// <summary>
        /// The transcript of the sentence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, of the sentence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The ending time, in milliseconds, of the sentence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Sentiment Sentiment { get; set; } = default!;

        /// <summary>
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public object? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcript of the sentence
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the sentence
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the sentence
        /// </param>
        /// <param name="sentiment"></param>
        /// <param name="confidence">
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </param>
        /// <param name="speaker">
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </param>
        public SentimentAnalysisResult(
            string text,
            int start,
            int end,
            global::G.Sentiment sentiment,
            double confidence,
            object? speaker)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Sentiment = sentiment;
            this.Confidence = confidence;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        public SentimentAnalysisResult()
        {
        }
    }
}