//HintName: G.Models.CrossValidationInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossValidationInput
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
        /// Number of windows to evaluate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_windows", Required = global::Newtonsoft.Json.Required.Always)]
        public int NWindows { get; set; } = default!;

        /// <summary>
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("h", Required = global::Newtonsoft.Json.Required.Always)]
        public int H { get; set; } = default!;

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
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? Level { get; set; }

        /// <summary>
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_steps")]
        public int? FinetuneSteps { get; set; }

        /// <summary>
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_loss")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CrossValidationInputFinetuneLossJsonConverter))]
        public global::G.CrossValidationInputFinetuneLoss? FinetuneLoss { get; set; }

        /// <summary>
        /// The depth of the finetuning. Uses a scale from 1 to 5, where 1 means little finetuning, and 5 means that the entire model is finetuned. By default, the value is set to 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_depth")]
        public int? FinetuneDepth { get; set; }

        /// <summary>
        /// ID of previously finetuned model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned_model_id")]
        public string? FinetunedModelId { get; set; }

        /// <summary>
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_size")]
        public int? StepSize { get; set; }

        /// <summary>
        /// Zero-based indices of the exogenous features to treat as historical.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hist_exog")]
        public global::System.Collections.Generic.IList<int>? HistExog { get; set; }

        /// <summary>
        /// Fine-tune the model in each window. If `False`, only fine-tunes on the first window. Only used if `finetune_steps` &gt; 0.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refit")]
        public bool? Refit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossValidationInput" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="nWindows">
        /// Number of windows to evaluate.
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="level">
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </param>
        /// <param name="finetuneSteps">
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="finetuneLoss">
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="finetuneDepth">
        /// The depth of the finetuning. Uses a scale from 1 to 5, where 1 means little finetuning, and 5 means that the entire model is finetuned. By default, the value is set to 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="finetunedModelId">
        /// ID of previously finetuned model
        /// </param>
        /// <param name="stepSize">
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </param>
        /// <param name="histExog">
        /// Zero-based indices of the exogenous features to treat as historical.
        /// </param>
        /// <param name="refit">
        /// Fine-tune the model in each window. If `False`, only fine-tunes on the first window. Only used if `finetune_steps` &gt; 0.<br/>
        /// Default Value: true
        /// </param>
        public CrossValidationInput(
            global::G.SeriesWithExogenous series,
            string freq,
            int nWindows,
            int h,
            object? model,
            bool? cleanExFirst,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level,
            int? finetuneSteps,
            global::G.CrossValidationInputFinetuneLoss? finetuneLoss,
            int? finetuneDepth,
            string? finetunedModelId,
            int? stepSize,
            global::System.Collections.Generic.IList<int>? histExog,
            bool? refit)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
            this.NWindows = nWindows;
            this.H = h;
            this.Model = model;
            this.CleanExFirst = cleanExFirst;
            this.Level = level;
            this.FinetuneSteps = finetuneSteps;
            this.FinetuneLoss = finetuneLoss;
            this.FinetuneDepth = finetuneDepth;
            this.FinetunedModelId = finetunedModelId;
            this.StepSize = stepSize;
            this.HistExog = histExog;
            this.Refit = refit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossValidationInput" /> class.
        /// </summary>
        public CrossValidationInput()
        {
        }
    }
}