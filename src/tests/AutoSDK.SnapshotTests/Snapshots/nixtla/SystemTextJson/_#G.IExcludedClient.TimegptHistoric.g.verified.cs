//HintName: G.IExcludedClient.TimegptHistoric.g.cs
#nullable enable

namespace G
{
    public partial interface IExcludedClient
    {
        /// <summary>
        /// Foundational Time Series Model Historic (Beta)<br/>
        /// Based on the provided data, this endpoint predicts time series data for the in-sample period (historical period). It takes a JSON as an input, including information like the series frequency and the historical data. (See below for a full description of the parameters.) The response contains the predicted values for the historical period. Usually useful for anomaly detection. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> TimegptHistoricAsync(

            global::G.SingleSeriesInsampleForecast request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Historic (Beta)<br/>
        /// Based on the provided data, this endpoint predicts time series data for the in-sample period (historical period). It takes a JSON as an input, including information like the series frequency and the historical data. (See below for a full description of the parameters.) The response contains the predicted values for the historical period. Usually useful for anomaly detection. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.<br/>
        /// Default Value: D
        /// </param>
        /// <param name="level">
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </param>
        /// <param name="y">
        /// The historical time series data provided as a dictionary. Each key is a timestamp (string format: YYYY-MM-DD) and the corresponding value is the observation at that time point. For example: {"2021-01-01": 0.1, "2021-01-02": 0.4}.<br/>
        /// Default Value: {"2015-12-02":4.390508031418598,"2015-12-03":5.721514930979356,"2015-12-04":4.822107008573151,"2015-12-05":4.359065463975175,"2015-12-06":3.3892383947112377,"2015-12-07":5.167152904533249,"2015-12-08":3.50069769010154,"2015-12-09":7.134184006256638,"2015-12-10":7.709302084008234,"2015-12-11":3.0675321506062216,"2015-12-12":6.333800304661317,"2015-12-13":4.231159358023236,"2015-12-14":4.5443564887514585,"2015-12-15":7.404773106341288,"2015-12-16":0.5682884655830955,"2015-12-17":0.6970343976123257,"2015-12-18":0.16174717952260576,"2015-12-19":6.660958764383504,"2015-12-20":6.225254007598804,"2015-12-21":6.960097185974553,"2015-12-22":7.828946737862112,"2015-12-23":6.393268513733789,"2015-12-24":3.6918348980234548,"2015-12-25":6.244233410291644,"2015-12-26":0.9461954069514658,"2015-12-27":5.119368170620191,"2015-12-28":1.1468262992723712,"2015-12-29":7.557351336396671,"2015-12-30":4.174786574000573,"2015-12-31":3.3172955199241887,"2016-01-01":2.1164448968370158,"2016-01-02":6.193869515473733,"2016-01-03":3.6492026577323884,"2016-01-04":4.547471590949188,"2016-01-05":0.15031840349084113,"2016-01-06":4.9410839766070165,"2016-01-07":4.896765781779371,"2016-01-08":4.935471974998055,"2016-01-09":7.549984628116993,"2016-01-10":5.454562392827867,"2016-01-11":2.876063204590288,"2016-01-12":3.4962556303947316,"2016-01-13":5.581049567418119}
        /// </param>
        /// <param name="x">
        /// The exogenous variables provided as a dictionary. Each key is a timestamp (string format: YYYY-MM-DD) and the corresponding value is a list of exogenous variable values at that time point. For example: {"2021-01-01": [0.1], "2021-01-02": [0.4]}. This should also include forecasting horizon (fh) additional timestamps to calculate the future values.
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> TimegptHistoricAsync(
            object? model = default,
            string? freq = default,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level = default,
            object? y = default,
            object? x = default,
            bool? cleanExFirst = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}