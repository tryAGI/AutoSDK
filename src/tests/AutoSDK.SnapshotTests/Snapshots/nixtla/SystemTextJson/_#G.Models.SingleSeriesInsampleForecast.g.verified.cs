//HintName: G.Models.SingleSeriesInsampleForecast.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleSeriesInsampleForecast
    {
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
        /// The historical time series data provided as a dictionary. Each key is a timestamp (string format: YYYY-MM-DD) and the corresponding value is the observation at that time point. For example: {"2021-01-01": 0.1, "2021-01-02": 0.4}.<br/>
        /// Default Value: {"2015-12-02":4.390508031418598,"2015-12-03":5.721514930979356,"2015-12-04":4.822107008573151,"2015-12-05":4.359065463975175,"2015-12-06":3.3892383947112377,"2015-12-07":5.167152904533249,"2015-12-08":3.50069769010154,"2015-12-09":7.134184006256638,"2015-12-10":7.709302084008234,"2015-12-11":3.0675321506062216,"2015-12-12":6.333800304661317,"2015-12-13":4.231159358023236,"2015-12-14":4.5443564887514585,"2015-12-15":7.404773106341288,"2015-12-16":0.5682884655830955,"2015-12-17":0.6970343976123257,"2015-12-18":0.16174717952260576,"2015-12-19":6.660958764383504,"2015-12-20":6.225254007598804,"2015-12-21":6.960097185974553,"2015-12-22":7.828946737862112,"2015-12-23":6.393268513733789,"2015-12-24":3.6918348980234548,"2015-12-25":6.244233410291644,"2015-12-26":0.9461954069514658,"2015-12-27":5.119368170620191,"2015-12-28":1.1468262992723712,"2015-12-29":7.557351336396671,"2015-12-30":4.174786574000573,"2015-12-31":3.3172955199241887,"2016-01-01":2.1164448968370158,"2016-01-02":6.193869515473733,"2016-01-03":3.6492026577323884,"2016-01-04":4.547471590949188,"2016-01-05":0.15031840349084113,"2016-01-06":4.9410839766070165,"2016-01-07":4.896765781779371,"2016-01-08":4.935471974998055,"2016-01-09":7.549984628116993,"2016-01-10":5.454562392827867,"2016-01-11":2.876063204590288,"2016-01-12":3.4962556303947316,"2016-01-13":5.581049567418119}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public object? Y { get; set; }

        /// <summary>
        /// The exogenous variables provided as a dictionary. Each key is a timestamp (string format: YYYY-MM-DD) and the corresponding value is a list of exogenous variable values at that time point. For example: {"2021-01-01": [0.1], "2021-01-02": [0.4]}. This should also include forecasting horizon (fh) additional timestamps to calculate the future values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public object? X { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clean_ex_first")]
        public bool? CleanExFirst { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSeriesInsampleForecast" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleSeriesInsampleForecast(
            object? model,
            string? freq,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level,
            object? y,
            object? x,
            bool? cleanExFirst)
        {
            this.Model = model;
            this.Freq = freq;
            this.Level = level;
            this.Y = y;
            this.X = x;
            this.CleanExFirst = cleanExFirst;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSeriesInsampleForecast" /> class.
        /// </summary>
        public SingleSeriesInsampleForecast()
        {
        }
    }
}