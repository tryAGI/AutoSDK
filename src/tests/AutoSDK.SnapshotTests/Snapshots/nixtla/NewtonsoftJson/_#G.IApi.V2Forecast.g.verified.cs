//HintName: G.IApi.V2Forecast.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Foundational Time Series Model Multi Series<br/>
        /// Based on the provided data, this endpoint predicts the future values of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains the predicted values for each series based on the input arguments. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ForecastOutput> V2ForecastAsync(

            global::G.ForecastInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Multi Series<br/>
        /// Based on the provided data, this endpoint predicts the future values of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains the predicted values for each series based on the input arguments. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.
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
        /// <param name="featureContributions">
        /// Compute the exogenous features contributions to the forecast.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ForecastOutput> V2ForecastAsync(
            global::G.SeriesWithFutureExogenous series,
            string freq,
            int h,
            object? model = default,
            bool? cleanExFirst = default,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level = default,
            int? finetuneSteps = default,
            global::G.ForecastInputFinetuneLoss? finetuneLoss = default,
            int? finetuneDepth = default,
            string? finetunedModelId = default,
            bool? featureContributions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}