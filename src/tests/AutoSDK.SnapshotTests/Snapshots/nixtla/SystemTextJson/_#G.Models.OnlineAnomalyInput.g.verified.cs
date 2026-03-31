//HintName: G.Models.OnlineAnomalyInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineAnomalyInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SeriesWithExogenous Series { get; set; }

        /// <summary>
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Freq { get; set; }

        /// <summary>
        /// Window over which to detect anomalies starting from the end of the series. This window is not considered when calculating the anomaly threshold to avoid bias from abnormal samples, unless there are less than 6 * detection_size forecasted samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DetectionSize { get; set; }

        /// <summary>
        /// The thresholding method to detect anomalies<br/>
        /// Default Value: univariate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OnlineAnomalyInputThresholdMethodJsonConverter))]
        public global::G.OnlineAnomalyInputThresholdMethod? ThresholdMethod { get; set; }

        /// <summary>
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int H { get; set; }

        /// <summary>
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public object? Model { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

        /// <summary>
        /// Specifies the confidence level for the prediction interval used in anomaly detection. It is represented as a percentage between 0 and 100. For instance, a level of 95 indicates that the generated prediction interval captures the true future observation 95% of the time. Any observed values outside of this interval would be considered anomalies. A higher level leads to wider prediction intervals and potentially fewer detected anomalies, whereas a lower level results in narrower intervals and potentially more detected anomalies. Default: 99.<br/>
        /// Default Value: 99
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, double?>))]
        public global::G.AnyOf<int?, double?>? Level { get; set; }

        /// <summary>
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_steps")]
        public int? FinetuneSteps { get; set; }

        /// <summary>
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_loss")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OnlineAnomalyInputFinetuneLossJsonConverter))]
        public global::G.OnlineAnomalyInputFinetuneLoss? FinetuneLoss { get; set; }

        /// <summary>
        /// The depth of the finetuning. Uses a scale from 1 to 5, where 1 means little finetuning, and 5 means that the entire model is finetuned. By default, the value is set to 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_depth")]
        public int? FinetuneDepth { get; set; }

        /// <summary>
        /// ID of previously finetuned model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_model_id")]
        public string? FinetunedModelId { get; set; }

        /// <summary>
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_size")]
        public int? StepSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyInput" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="detectionSize">
        /// Window over which to detect anomalies starting from the end of the series. This window is not considered when calculating the anomaly threshold to avoid bias from abnormal samples, unless there are less than 6 * detection_size forecasted samples.
        /// </param>
        /// <param name="h">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.
        /// </param>
        /// <param name="thresholdMethod">
        /// The thresholding method to detect anomalies<br/>
        /// Default Value: univariate
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
        /// Specifies the confidence level for the prediction interval used in anomaly detection. It is represented as a percentage between 0 and 100. For instance, a level of 95 indicates that the generated prediction interval captures the true future observation 95% of the time. Any observed values outside of this interval would be considered anomalies. A higher level leads to wider prediction intervals and potentially fewer detected anomalies, whereas a lower level results in narrower intervals and potentially more detected anomalies. Default: 99.<br/>
        /// Default Value: 99
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnlineAnomalyInput(
            global::G.SeriesWithExogenous series,
            string freq,
            int detectionSize,
            int h,
            global::G.OnlineAnomalyInputThresholdMethod? thresholdMethod,
            object? model,
            bool? cleanExFirst,
            global::G.AnyOf<int?, double?>? level,
            int? finetuneSteps,
            global::G.OnlineAnomalyInputFinetuneLoss? finetuneLoss,
            int? finetuneDepth,
            string? finetunedModelId,
            int? stepSize)
        {
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
            this.DetectionSize = detectionSize;
            this.ThresholdMethod = thresholdMethod;
            this.H = h;
            this.Model = model;
            this.CleanExFirst = cleanExFirst;
            this.Level = level;
            this.FinetuneSteps = finetuneSteps;
            this.FinetuneLoss = finetuneLoss;
            this.FinetuneDepth = finetuneDepth;
            this.FinetunedModelId = finetunedModelId;
            this.StepSize = stepSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineAnomalyInput" /> class.
        /// </summary>
        public OnlineAnomalyInput()
        {
        }
    }
}