//HintName: G.Models.TopicDetectionModelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the Topic Detection model, if it is enabled.<br/>
    /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.<br/>
    /// Example: {"status":"success","results":[{"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter de Carlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University Varsity. Good morning, professor. Good morning.","labels":[{"relevance":0.988274097442627,"label":"Home\u0026Garden\u003EIndoorEnvironmentalQuality"},{"relevance":0.5821335911750793,"label":"NewsAndPolitics\u003EWeather"},{"relevance":0.0042327106930315495,"label":"MedicalHealth\u003EDiseasesAndConditions\u003ELungAndRespiratoryHealth"},{"relevance":0.0033971222583204508,"label":"NewsAndPolitics\u003EDisasters"},{"relevance":0.002469958271831274,"label":"BusinessAndFinance\u003EBusiness\u003EGreenSolutions"},{"relevance":0.0014376690378412604,"label":"MedicalHealth\u003EDiseasesAndConditions\u003ECancer"},{"relevance":0.0014294233405962586,"label":"Science\u003EEnvironment"},{"relevance":0.001234519761055708,"label":"Travel\u003ETravelLocations\u003EPolarTravel"},{"relevance":0.0010231725173071027,"label":"MedicalHealth\u003EDiseasesAndConditions\u003EColdAndFlu"},{"relevance":0.0007445293595083058,"label":"BusinessAndFinance\u003EIndustries\u003EPowerAndEnergyIndustry"}],"timestamp":{"start":250,"end":28840}}],"summary":{"NewsAndPolitics\u003EWeather":1,"Home\u0026Garden\u003EIndoorEnvironmentalQuality":0.9043831825256348,"Science\u003EEnvironment":0.16117265820503235,"BusinessAndFinance\u003EIndustries\u003EEnvironmentalServicesIndustry":0.14393523335456848,"MedicalHealth\u003EDiseasesAndConditions\u003ELungAndRespiratoryHealth":0.11401086300611496,"BusinessAndFinance\u003EBusiness\u003EGreenSolutions":0.06348437070846558,"NewsAndPolitics\u003EDisasters":0.05041387677192688,"Travel\u003ETravelLocations\u003EPolarTravel":0.01308488193899393,"HealthyLiving":0.008222488686442375,"MedicalHealth\u003EDiseasesAndConditions\u003EColdAndFlu":0.0022315620444715023,"MedicalHealth\u003EDiseasesAndConditions\u003EHeartAndCardiovascularDiseases":0.00213034451007843,"HealthyLiving\u003EWellness\u003ESmokingCessation":0.001540527562610805,"MedicalHealth\u003EDiseasesAndConditions\u003EInjuries":0.0013950627762824297,"BusinessAndFinance\u003EIndustries\u003EPowerAndEnergyIndustry":0.0012570273829624057,"MedicalHealth\u003EDiseasesAndConditions\u003ECancer":0.001097781932912767,"MedicalHealth\u003EDiseasesAndConditions\u003EAllergies":0.0010148967849090695,"MedicalHealth\u003EDiseasesAndConditions\u003EMentalHealth":0.000717321818228811,"Style\u0026Fashion\u003EPersonalCare\u003EDeodorantAndAntiperspirant":0.0006022014422342181,"Technology\u0026Computing\u003EComputing\u003EComputerNetworking":0.0005461975233629346,"MedicalHealth\u003EDiseasesAndConditions\u003EInjuries\u003EFirstAid":0.0004885646631009877}}
    /// </summary>
    public sealed partial class TopicDetectionModelResult
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioIntelligenceModelStatus Status { get; set; } = default!;

        /// <summary>
        /// An array of results for the Topic Detection model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionResult> Results { get; set; } = default!;

        /// <summary>
        /// The overall relevance of topic to the entire audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Summary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="results">
        /// An array of results for the Topic Detection model
        /// </param>
        /// <param name="summary">
        /// The overall relevance of topic to the entire audio file
        /// </param>
        public TopicDetectionModelResult(
            global::G.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.IList<global::G.TopicDetectionResult> results,
            global::System.Collections.Generic.Dictionary<string, double> summary)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        public TopicDetectionModelResult()
        {
        }
    }
}