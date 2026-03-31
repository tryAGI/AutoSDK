//HintName: G.Models.InSampleInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InSampleInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SeriesWithExogenous Series { get; set; } = default!;

        /// <summary>
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("freq", Required = global::Newtonsoft.Json.Required.Always)]
        public string Freq { get; set; } = default!;

        /// <summary>
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public object? Model { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

        /// <summary>
        /// ID of previously finetuned model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned_model_id")]
        public string? FinetunedModelId { get; set; }

        /// <summary>
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? Level { get; set; }

        /// <summary>
        /// Compute the exogenous features contributions to the forecast.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feature_contributions")]
        public bool? FeatureContributions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InSampleInput" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="finetunedModelId">
        /// ID of previously finetuned model
        /// </param>
        /// <param name="level">
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </param>
        /// <param name="featureContributions">
        /// Compute the exogenous features contributions to the forecast.<br/>
        /// Default Value: false
        /// </param>
        public InSampleInput(
            global::G.SeriesWithExogenous series,
            string freq,
            object? model,
            bool? cleanExFirst,
            string? finetunedModelId,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level,
            bool? featureContributions)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
            this.Model = model;
            this.CleanExFirst = cleanExFirst;
            this.FinetunedModelId = finetunedModelId;
            this.Level = level;
            this.FeatureContributions = featureContributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InSampleInput" /> class.
        /// </summary>
        public InSampleInput()
        {
        }
    }
}