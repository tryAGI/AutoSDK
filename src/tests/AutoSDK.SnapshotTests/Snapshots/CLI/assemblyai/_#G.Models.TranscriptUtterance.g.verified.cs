//HintName: G.Models.TranscriptUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"confidence":0.9359033333333334,"end":26950,"speaker":"A","start":250,"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter de Carlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University Varsity. Good morning, professor.","words":[{"text":"Smoke","start":250,"end":650,"confidence":0.97503,"speaker":"A"},{"text":"from","start":730,"end":1022,"confidence":0.99999,"speaker":"A"},{"text":"hundreds","start":1076,"end":1418,"confidence":0.99843,"speaker":"A"},{"text":"of","start":1434,"end":1614,"confidence":0.85,"speaker":"A"},{"text":"wildfires","start":1652,"end":2346,"confidence":0.89657,"speaker":"A"},{"text":"in","start":2378,"end":2526,"confidence":0.99994,"speaker":"A"},{"text":"Canada","start":2548,"end":3130,"confidence":0.93864,"speaker":"A"},{"text":"is","start":3210,"end":3454,"confidence":0.999,"speaker":"A"},{"text":"triggering","start":3492,"end":3946,"confidence":0.75366,"speaker":"A"},{"text":"air","start":3978,"end":4174,"confidence":1,"speaker":"A"},{"text":"quality","start":4212,"end":4558,"confidence":0.87745,"speaker":"A"},{"text":"alerts","start":4644,"end":5114,"confidence":0.94739,"speaker":"A"},{"text":"throughout","start":5162,"end":5466,"confidence":0.99726,"speaker":"A"},{"text":"the","start":5498,"end":5694,"confidence":0.79,"speaker":"A"},{"text":"US.","start":5732,"end":6382,"confidence":0.88,"speaker":"A"}]}
    /// </summary>
    public sealed partial class TranscriptUtterance
    {
        /// <summary>
        /// The confidence score for the transcript of this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the utterance in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the utterance in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The text for this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The words in the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptWord> Words { get; set; }

        /// <summary>
        /// The speaker of this utterance, where each speaker is assigned a sequential capital letter - e.g. "A" for Speaker A, "B" for Speaker B, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptUtterance" /> class.
        /// </summary>
        /// <param name="confidence">
        /// The confidence score for the transcript of this utterance
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the utterance in the audio file
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the utterance in the audio file
        /// </param>
        /// <param name="text">
        /// The text for this utterance
        /// </param>
        /// <param name="words">
        /// The words in the utterance.
        /// </param>
        /// <param name="speaker">
        /// The speaker of this utterance, where each speaker is assigned a sequential capital letter - e.g. "A" for Speaker A, "B" for Speaker B, etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptUtterance(
            double confidence,
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<global::G.TranscriptWord> words,
            string speaker)
        {
            this.Confidence = confidence;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptUtterance" /> class.
        /// </summary>
        public TranscriptUtterance()
        {
        }
    }
}