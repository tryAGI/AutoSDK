//HintName: G.Models.TopicDetectionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the topic detection model<br/>
    /// Example: {"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter de Carlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University Varsity. Good morning, professor. Good morning.","labels":[{"relevance":0.988274097442627,"label":"Home\u0026Garden\u003EIndoorEnvironmentalQuality"},{"relevance":0.5821335911750793,"label":"NewsAndPolitics\u003EWeather"},{"relevance":0.0042327106930315495,"label":"MedicalHealth\u003EDiseasesAndConditions\u003ELungAndRespiratoryHealth"},{"relevance":0.0033971222583204508,"label":"NewsAndPolitics\u003EDisasters"},{"relevance":0.002469958271831274,"label":"BusinessAndFinance\u003EBusiness\u003EGreenSolutions"},{"relevance":0.0014376690378412604,"label":"MedicalHealth\u003EDiseasesAndConditions\u003ECancer"},{"relevance":0.0014294233405962586,"label":"Science\u003EEnvironment"},{"relevance":0.001234519761055708,"label":"Travel\u003ETravelLocations\u003EPolarTravel"},{"relevance":0.0010231725173071027,"label":"MedicalHealth\u003EDiseasesAndConditions\u003EColdAndFlu"},{"relevance":0.0007445293595083058,"label":"BusinessAndFinance\u003EIndustries\u003EPowerAndEnergyIndustry"}],"timestamp":{"start":250,"end":28840}}
    /// </summary>
    public sealed partial class TopicDetectionResult
    {
        /// <summary>
        /// The text in the transcript in which a detected topic occurs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionResultLabel>? Labels { get; set; }

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds<br/>
        /// Example: {"start":3978,"end":5114}
        /// </summary>
        /// <example>{"start":3978,"end":5114}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::G.Timestamp? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The text in the transcript in which a detected topic occurs
        /// </param>
        /// <param name="labels"></param>
        /// <param name="timestamp">
        /// Timestamp containing a start and end property in milliseconds<br/>
        /// Example: {"start":3978,"end":5114}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionResult(
            string text,
            global::System.Collections.Generic.IList<global::G.TopicDetectionResultLabel>? labels,
            global::G.Timestamp? timestamp)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Labels = labels;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        public TopicDetectionResult()
        {
        }
    }
}