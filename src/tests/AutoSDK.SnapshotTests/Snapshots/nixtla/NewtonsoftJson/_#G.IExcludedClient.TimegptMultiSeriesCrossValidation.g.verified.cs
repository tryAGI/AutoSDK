//HintName: G.IExcludedClient.TimegptMultiSeriesCrossValidation.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IExcludedClient
    {
        /// <summary>
        /// Foundational Time Series Model Multi Series Cross Validation (Beta)<br/>
        /// Perform Cross Validation for multiple series
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> TimegptMultiSeriesCrossValidationAsync(

            global::G.MultiSeriesCrossValidation request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Foundational Time Series Model Multi Series Cross Validation (Beta)<br/>
        /// Perform Cross Validation for multiple series
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
        /// <param name="fh">
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="y">
        /// The historical time series data provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "y"], "data": [["ts_0", "2021-01-01", 0.7], ["ts_0", "2021-01-02", 0.8]}.<br/>
        /// Default Value: {"columns":["unique_id","ds","y"],"data":[["PeytonManning","2015-12-02",4.390508031418598],["PeytonManning","2015-12-03",5.721514930979356],["PeytonManning","2015-12-04",4.822107008573151],["PeytonManning","2015-12-05",4.359065463975175],["PeytonManning","2015-12-06",3.3892383947112377],["PeytonManning","2015-12-07",5.167152904533249],["PeytonManning","2015-12-08",3.50069769010154],["PeytonManning","2015-12-09",7.134184006256638],["PeytonManning","2015-12-10",7.709302084008234],["PeytonManning","2015-12-11",3.0675321506062216],["PeytonManning","2015-12-12",6.333800304661317],["PeytonManning","2015-12-13",4.231159358023236],["PeytonManning","2015-12-14",4.5443564887514585],["PeytonManning","2015-12-15",7.404773106341288],["PeytonManning","2015-12-16",0.5682884655830955],["PeytonManning","2015-12-17",0.6970343976123257],["PeytonManning","2015-12-18",0.16174717952260576],["PeytonManning","2015-12-19",6.660958764383504],["PeytonManning","2015-12-20",6.225254007598804],["PeytonManning","2015-12-21",6.960097185974553],["PeytonManning","2015-12-22",7.828946737862112],["PeytonManning","2015-12-23",6.393268513733789],["PeytonManning","2015-12-24",3.6918348980234548],["PeytonManning","2015-12-25",6.244233410291644],["PeytonManning","2015-12-26",0.9461954069514658],["PeytonManning","2015-12-27",5.119368170620191],["PeytonManning","2015-12-28",1.1468262992723712],["PeytonManning","2015-12-29",7.557351336396671],["PeytonManning","2015-12-30",4.174786574000573],["PeytonManning","2015-12-31",3.3172955199241887],["PeytonManning","2016-01-01",2.1164448968370158],["PeytonManning","2016-01-02",6.193869515473733],["PeytonManning","2016-01-03",3.6492026577323884],["PeytonManning","2016-01-04",4.547471590949188],["PeytonManning","2016-01-05",0.15031840349084113],["PeytonManning","2016-01-06",4.9410839766070165],["PeytonManning","2016-01-07",4.896765781779371],["PeytonManning","2016-01-08",4.935471974998055],["PeytonManning","2016-01-09",7.549984628116993],["PeytonManning","2016-01-10",5.454562392827867],["PeytonManning","2016-01-11",2.876063204590288],["PeytonManning","2016-01-12",3.4962556303947316],["PeytonManning","2016-01-13",5.581049567418119],["TomBrady","2015-12-02",4.390508031418598],["TomBrady","2015-12-03",5.721514930979356],["TomBrady","2015-12-04",4.822107008573151],["TomBrady","2015-12-05",4.359065463975175],["TomBrady","2015-12-06",3.3892383947112377],["TomBrady","2015-12-07",5.167152904533249],["TomBrady","2015-12-08",3.50069769010154],["TomBrady","2015-12-09",7.134184006256638],["TomBrady","2015-12-10",7.709302084008234],["TomBrady","2015-12-11",3.0675321506062216],["TomBrady","2015-12-12",6.333800304661317],["TomBrady","2015-12-13",4.231159358023236],["TomBrady","2015-12-14",4.5443564887514585],["TomBrady","2015-12-15",7.404773106341288],["TomBrady","2015-12-16",0.5682884655830955],["TomBrady","2015-12-17",0.6970343976123257],["TomBrady","2015-12-18",0.16174717952260576],["TomBrady","2015-12-19",6.660958764383504],["TomBrady","2015-12-20",6.225254007598804],["TomBrady","2015-12-21",6.960097185974553],["TomBrady","2015-12-22",7.828946737862112],["TomBrady","2015-12-23",6.393268513733789],["TomBrady","2015-12-24",3.6918348980234548],["TomBrady","2015-12-25",6.244233410291644],["TomBrady","2015-12-26",0.9461954069514658],["TomBrady","2015-12-27",5.119368170620191],["TomBrady","2015-12-28",1.1468262992723712],["TomBrady","2015-12-29",7.557351336396671],["TomBrady","2015-12-30",4.174786574000573],["TomBrady","2015-12-31",3.3172955199241887],["TomBrady","2016-01-01",2.1164448968370158],["TomBrady","2016-01-02",6.193869515473733],["TomBrady","2016-01-03",3.6492026577323884],["TomBrady","2016-01-04",4.547471590949188],["TomBrady","2016-01-05",0.15031840349084113],["TomBrady","2016-01-06",4.9410839766070165],["TomBrady","2016-01-07",4.896765781779371],["TomBrady","2016-01-08",4.935471974998055],["TomBrady","2016-01-09",7.549984628116993],["TomBrady","2016-01-10",5.454562392827867],["TomBrady","2016-01-11",2.876063204590288],["TomBrady","2016-01-12",3.4962556303947316],["TomBrady","2016-01-13",5.581049567418119]]}
        /// </param>
        /// <param name="x">
        /// The exogenous  variables provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "ex_1", "ex_2"], "data": [["ts_0", "2021-01-01", 0.2, 0.67], ["ts_0", "2021-01-02", 0.4, 0.7]}. This should also include forecasting horizon (fh) additional timestamps for each unique_id to calculate the future values.
        /// </param>
        /// <param name="nWindows">
        /// Number of windows to evaluate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stepSize">
        /// Step size between each cross validation window. If None it will be equal to the forecasting horizon.
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="finetuneSteps">
        /// The number of tuning steps used to train the large time model on the data. Set this value to 0 for zero-shot inference, i.e., to make predictions without any further model tuning.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="finetuneLoss">
        /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> TimegptMultiSeriesCrossValidationAsync(
            object? model = default,
            string? freq = default,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level = default,
            int? fh = default,
            object? y = default,
            global::G.MultiSeriesInput? x = default,
            int? nWindows = default,
            int? stepSize = default,
            bool? cleanExFirst = default,
            int? finetuneSteps = default,
            global::G.MultiSeriesCrossValidationFinetuneLoss? finetuneLoss = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}