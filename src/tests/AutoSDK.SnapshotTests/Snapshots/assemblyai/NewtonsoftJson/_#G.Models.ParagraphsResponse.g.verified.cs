//HintName: G.Models.ParagraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"paragraphs":[{"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter Decarlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University. Good morning, professor.","start":250,"end":26950,"confidence":0.73033,"words":[{"text":"Smoke","start":250,"end":650,"confidence":0.73033,"speaker":""},{"text":"from","start":730,"end":1022,"confidence":1,"speaker":""},{"text":"hundreds","start":1076,"end":1466,"confidence":0.99992,"speaker":""},{"text":"of","start":1498,"end":1646,"confidence":1,"speaker":""}]},{"text":"Good morning. So what is it about the conditions right now that have caused this round of wildfires to affect so many people so far away? Well, there\u0027s a couple of things. The season has been pretty dry already, and then the fact that we\u0027re getting hit in the US. Is because there\u0027s a couple of weather systems that are essentially channeling the smoke from those Canadian wildfires through Pennsylvania into the Mid Atlantic and the Northeast and kind of just dropping the smoke there.","start":27850,"end":56190,"confidence":0.99667,"words":[{"text":"Good","start":27850,"end":28262,"confidence":0.99667,"speaker":""},{"text":"morning.","start":28316,"end":28920,"confidence":0.99742,"speaker":""},{"text":"So","start":29290,"end":29702,"confidence":0.94736,"speaker":""}]}],"id":"d5a3d302-066e-43fb-b63b-8f57baf185db","confidence":0.9578730257009361,"audio_duration":281}
    /// </summary>
    public sealed partial class ParagraphsResponse
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
        [global::Newtonsoft.Json.JsonProperty("paragraphs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptParagraph> Paragraphs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="paragraphs"></param>
        public ParagraphsResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptParagraph> paragraphs)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Paragraphs = paragraphs ?? throw new global::System.ArgumentNullException(nameof(paragraphs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        public ParagraphsResponse()
        {
        }
    }
}