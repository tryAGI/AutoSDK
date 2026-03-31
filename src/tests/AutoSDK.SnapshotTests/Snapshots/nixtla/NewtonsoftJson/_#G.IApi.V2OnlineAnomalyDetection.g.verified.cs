//HintName: G.IApi.V2OnlineAnomalyDetection.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Foundational Time Series Model Online Multi Series Anomaly Detector<br/>
        /// This endpoint performs online anomaly detection based on the provided data. It uses cross-validation for more robust detection of anomalies and it supports detection for univariate and multivariate scenarios. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains a flag indicating if the date has an anomaly, it provides the prediction interval used to define if an observation is an anomaly, and it reports the associated z-score for each point. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OnlineAnomalyOutput> V2OnlineAnomalyDetectionAsync(

            global::G.OnlineAnomalyInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Online Multi Series Anomaly Detector<br/>
        /// This endpoint performs online anomaly detection based on the provided data. It uses cross-validation for more robust detection of anomalies and it supports detection for univariate and multivariate scenarios. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains a flag indicating if the date has an anomaly, it provides the prediction interval used to define if an observation is an anomaly, and it reports the associated z-score for each point. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
        /// </param>
        /// <param name="detectionSize">
        /// Window over which to detect anomalies starting from the end of the series. This window is not considered when calculating the anomaly threshold to avoid bias from abnormal samples, unless there are less than 6 * detection_size forecasted samples.
        /// </param>
        /// <param name="thresholdMethod">
        /// The thresholding method to detect anomalies<br/>
        /// Default Value: univariate
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OnlineAnomalyOutput> V2OnlineAnomalyDetectionAsync(
            global::G.SeriesWithExogenous series,
            string freq,
            int detectionSize,
            int h,
            global::G.OnlineAnomalyInputThresholdMethod? thresholdMethod = default,
            object? model = default,
            bool? cleanExFirst = default,
            global::G.AnyOf<int?, double?>? level = default,
            int? finetuneSteps = default,
            global::G.OnlineAnomalyInputFinetuneLoss? finetuneLoss = default,
            int? finetuneDepth = default,
            string? finetunedModelId = default,
            int? stepSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}