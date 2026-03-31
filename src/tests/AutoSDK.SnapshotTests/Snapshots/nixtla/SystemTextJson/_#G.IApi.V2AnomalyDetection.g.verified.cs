//HintName: G.IApi.V2AnomalyDetection.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Foundational Time Series Model Multi Series Anomaly Detector<br/>
        /// Based on the provided data, this endpoint detects the anomalies in the historical perdiod of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains a flag indicating if the date has an anomaly and also provides the prediction interval used to define if an observation is an anomaly.Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnomalyDetectionOutput> V2AnomalyDetectionAsync(

            global::G.AnomalyDetectionInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Multi Series Anomaly Detector<br/>
        /// Based on the provided data, this endpoint detects the anomalies in the historical perdiod of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains a flag indicating if the date has an anomaly and also provides the prediction interval used to define if an observation is an anomaly.Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
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
        /// Specifies the confidence level for the prediction interval used in anomaly detection. It is represented as a percentage between 0 and 100. For instance, a level of 95 indicates that the generated prediction interval captures the true future observation 95% of the time. Any observed values outside of this interval would be considered anomalies. A higher level leads to wider prediction intervals and potentially fewer detected anomalies, whereas a lower level results in narrower intervals and potentially more detected anomalies. Default: 99.<br/>
        /// Default Value: 99
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnomalyDetectionOutput> V2AnomalyDetectionAsync(
            global::G.SeriesWithExogenous series,
            string freq,
            object? model = default,
            bool? cleanExFirst = default,
            string? finetunedModelId = default,
            global::G.AnyOf<int?, double?>? level = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}