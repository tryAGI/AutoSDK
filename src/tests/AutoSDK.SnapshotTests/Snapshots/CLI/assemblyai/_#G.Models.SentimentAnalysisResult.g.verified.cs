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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SentimentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Sentiment Sentiment { get; set; }

        /// <summary>
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public object? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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