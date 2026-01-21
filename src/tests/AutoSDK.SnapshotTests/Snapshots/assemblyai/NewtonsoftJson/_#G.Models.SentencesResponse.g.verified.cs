//HintName: G.Models.SentencesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"sentences":[{"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US.","start":250,"end":6350,"confidence":0.72412,"words":[{"text":"Smoke","start":250,"end":650,"confidence":0.72412,"speaker":""},{"text":"from","start":730,"end":1022,"confidence":0.99996,"speaker":""},{"text":"hundreds","start":1076,"end":1466,"confidence":0.99992,"speaker":""},{"text":"of","start":1498,"end":1646,"confidence":1,"speaker":""}],"speaker":""},{"text":"Skylines from Maine to Maryland to Minnesota are gray and smoggy.","start":6500,"end":11050,"confidence":0.99819,"words":[{"text":"Skylines","start":6500,"end":7306,"confidence":0.99819,"speaker":""},{"text":"from","start":7338,"end":7534,"confidence":0.99987,"speaker":""},{"text":"Maine","start":7572,"end":7962,"confidence":0.9972,"speaker":""},{"text":"to","start":8026,"end":8206,"confidence":1,"speaker":""},{"text":"Maryland","start":8228,"end":8650,"confidence":0.5192,"speaker":""},{"text":"to","start":8730,"end":8926,"confidence":1,"speaker":""}],"speaker":""}],"id":"d5a3d302-066e-43fb-b63b-8f57baf185db","confidence":0.9579390654205628,"audio_duration":281}
    /// </summary>
    public sealed partial class SentencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptSentence> Sentences { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="sentences"></param>
        public SentencesResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptSentence> sentences)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        public SentencesResponse()
        {
        }
    }
}