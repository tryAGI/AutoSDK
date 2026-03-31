//HintName: G.Models.MultiSeriesForecast.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiSeriesForecast
    {
        /// <summary>
        /// Deprecated. Please use finetune_steps instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fewshot_steps")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? FewshotSteps { get; set; }

        /// <summary>
        /// Deprecated. Please use finetune_loss instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fewshot_loss")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.MultiSeriesForecastFewshotLoss2? FewshotLoss { get; set; }

        /// <summary>
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public object? Model { get; set; }

        /// <summary>
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.<br/>
        /// Default Value: D
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freq")]
        public string? Freq { get; set; }

        /// <summary>
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? Level { get; set; }

        /// <summary>
        /// The forecasting horizon. This represents the number of time steps into the future that the forecast should predict.<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fh")]
        public int? Fh { get; set; }

        /// <summary>
        /// The historical time series data provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "y"], "data": [["ts_0", "2021-01-01", 0.7], ["ts_0", "2021-01-02", 0.8]}.<br/>
        /// Default Value: {"columns":["unique_id","ds","y"],"data":[["PeytonManning","2015-12-02",4.390508031418598],["PeytonManning","2015-12-03",5.721514930979356],["PeytonManning","2015-12-04",4.822107008573151],["PeytonManning","2015-12-05",4.359065463975175],["PeytonManning","2015-12-06",3.3892383947112377],["PeytonManning","2015-12-07",5.167152904533249],["PeytonManning","2015-12-08",3.50069769010154],["PeytonManning","2015-12-09",7.134184006256638],["PeytonManning","2015-12-10",7.709302084008234],["PeytonManning","2015-12-11",3.0675321506062216],["PeytonManning","2015-12-12",6.333800304661317],["PeytonManning","2015-12-13",4.231159358023236],["PeytonManning","2015-12-14",4.5443564887514585],["PeytonManning","2015-12-15",7.404773106341288],["PeytonManning","2015-12-16",0.5682884655830955],["PeytonManning","2015-12-17",0.6970343976123257],["PeytonManning","2015-12-18",0.16174717952260576],["PeytonManning","2015-12-19",6.660958764383504],["PeytonManning","2015-12-20",6.225254007598804],["PeytonManning","2015-12-21",6.960097185974553],["PeytonManning","2015-12-22",7.828946737862112],["PeytonManning","2015-12-23",6.393268513733789],["PeytonManning","2015-12-24",3.6918348980234548],["PeytonManning","2015-12-25",6.244233410291644],["PeytonManning","2015-12-26",0.9461954069514658],["PeytonManning","2015-12-27",5.119368170620191],["PeytonManning","2015-12-28",1.1468262992723712],["PeytonManning","2015-12-29",7.557351336396671],["PeytonManning","2015-12-30",4.174786574000573],["PeytonManning","2015-12-31",3.3172955199241887],["PeytonManning","2016-01-01",2.1164448968370158],["PeytonManning","2016-01-02",6.193869515473733],["PeytonManning","2016-01-03",3.6492026577323884],["PeytonManning","2016-01-04",4.547471590949188],["PeytonManning","2016-01-05",0.15031840349084113],["PeytonManning","2016-01-06",4.9410839766070165],["PeytonManning","2016-01-07",4.896765781779371],["PeytonManning","2016-01-08",4.935471974998055],["PeytonManning","2016-01-09",7.549984628116993],["PeytonManning","2016-01-10",5.454562392827867],["PeytonManning","2016-01-11",2.876063204590288],["PeytonManning","2016-01-12",3.4962556303947316],["PeytonManning","2016-01-13",5.581049567418119],["TomBrady","2015-12-02",4.390508031418598],["TomBrady","2015-12-03",5.721514930979356],["TomBrady","2015-12-04",4.822107008573151],["TomBrady","2015-12-05",4.359065463975175],["TomBrady","2015-12-06",3.3892383947112377],["TomBrady","2015-12-07",5.167152904533249],["TomBrady","2015-12-08",3.50069769010154],["TomBrady","2015-12-09",7.134184006256638],["TomBrady","2015-12-10",7.709302084008234],["TomBrady","2015-12-11",3.0675321506062216],["TomBrady","2015-12-12",6.333800304661317],["TomBrady","2015-12-13",4.231159358023236],["TomBrady","2015-12-14",4.5443564887514585],["TomBrady","2015-12-15",7.404773106341288],["TomBrady","2015-12-16",0.5682884655830955],["TomBrady","2015-12-17",0.6970343976123257],["TomBrady","2015-12-18",0.16174717952260576],["TomBrady","2015-12-19",6.660958764383504],["TomBrady","2015-12-20",6.225254007598804],["TomBrady","2015-12-21",6.960097185974553],["TomBrady","2015-12-22",7.828946737862112],["TomBrady","2015-12-23",6.393268513733789],["TomBrady","2015-12-24",3.6918348980234548],["TomBrady","2015-12-25",6.244233410291644],["TomBrady","2015-12-26",0.9461954069514658],["TomBrady","2015-12-27",5.119368170620191],["TomBrady","2015-12-28",1.1468262992723712],["TomBrady","2015-12-29",7.557351336396671],["TomBrady","2015-12-30",4.174786574000573],["TomBrady","2015-12-31",3.3172955199241887],["TomBrady","2016-01-01",2.1164448968370158],["TomBrady","2016-01-02",6.193869515473733],["TomBrady","2016-01-03",3.6492026577323884],["TomBrady","2016-01-04",4.547471590949188],["TomBrady","2016-01-05",0.15031840349084113],["TomBrady","2016-01-06",4.9410839766070165],["TomBrady","2016-01-07",4.896765781779371],["TomBrady","2016-01-08",4.935471974998055],["TomBrady","2016-01-09",7.549984628116993],["TomBrady","2016-01-10",5.454562392827867],["TomBrady","2016-01-11",2.876063204590288],["TomBrady","2016-01-12",3.4962556303947316],["TomBrady","2016-01-13",5.581049567418119]]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public object? Y { get; set; }

        /// <summary>
        /// The exogenous  variables provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "ex_1", "ex_2"], "data": [["ts_0", "2021-01-01", 0.2, 0.67], ["ts_0", "2021-01-02", 0.4, 0.7]}. This should also include forecasting horizon (fh) additional timestamps for each unique_id to calculate the future values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public global::G.MultiSeriesInput? X { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultiSeriesForecastFinetuneLossJsonConverter))]
        public global::G.MultiSeriesForecastFinetuneLoss? FinetuneLoss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSeriesForecast" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiSeriesForecast(
            object? model,
            string? freq,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level,
            int? fh,
            object? y,
            global::G.MultiSeriesInput? x,
            bool? cleanExFirst,
            int? finetuneSteps,
            global::G.MultiSeriesForecastFinetuneLoss? finetuneLoss)
        {
            this.Model = model;
            this.Freq = freq;
            this.Level = level;
            this.Fh = fh;
            this.Y = y;
            this.X = x;
            this.CleanExFirst = cleanExFirst;
            this.FinetuneSteps = finetuneSteps;
            this.FinetuneLoss = finetuneLoss;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSeriesForecast" /> class.
        /// </summary>
        public MultiSeriesForecast()
        {
        }
    }
}