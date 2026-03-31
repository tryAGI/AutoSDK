//HintName: G.Models.SingleSeriesForecastFewshotLoss2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SingleSeriesForecastFewshotLoss2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mae")]
        Mae,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mape")]
        Mape,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mse")]
        Mse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rmse")]
        Rmse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smape")]
        Smape,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SingleSeriesForecastFewshotLoss2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleSeriesForecastFewshotLoss2 value)
        {
            return value switch
            {
                SingleSeriesForecastFewshotLoss2.Default => "default",
                SingleSeriesForecastFewshotLoss2.Mae => "mae",
                SingleSeriesForecastFewshotLoss2.Mape => "mape",
                SingleSeriesForecastFewshotLoss2.Mse => "mse",
                SingleSeriesForecastFewshotLoss2.Rmse => "rmse",
                SingleSeriesForecastFewshotLoss2.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleSeriesForecastFewshotLoss2? ToEnum(string value)
        {
            return value switch
            {
                "default" => SingleSeriesForecastFewshotLoss2.Default,
                "mae" => SingleSeriesForecastFewshotLoss2.Mae,
                "mape" => SingleSeriesForecastFewshotLoss2.Mape,
                "mse" => SingleSeriesForecastFewshotLoss2.Mse,
                "rmse" => SingleSeriesForecastFewshotLoss2.Rmse,
                "smape" => SingleSeriesForecastFewshotLoss2.Smape,
                _ => null,
            };
        }
    }
}