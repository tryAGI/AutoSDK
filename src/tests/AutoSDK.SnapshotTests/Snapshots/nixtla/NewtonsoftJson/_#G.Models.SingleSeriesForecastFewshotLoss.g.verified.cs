//HintName: G.Models.SingleSeriesForecastFewshotLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SingleSeriesForecastFewshotLoss
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
    public static class SingleSeriesForecastFewshotLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleSeriesForecastFewshotLoss value)
        {
            return value switch
            {
                SingleSeriesForecastFewshotLoss.Default => "default",
                SingleSeriesForecastFewshotLoss.Mae => "mae",
                SingleSeriesForecastFewshotLoss.Mape => "mape",
                SingleSeriesForecastFewshotLoss.Mse => "mse",
                SingleSeriesForecastFewshotLoss.Rmse => "rmse",
                SingleSeriesForecastFewshotLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleSeriesForecastFewshotLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => SingleSeriesForecastFewshotLoss.Default,
                "mae" => SingleSeriesForecastFewshotLoss.Mae,
                "mape" => SingleSeriesForecastFewshotLoss.Mape,
                "mse" => SingleSeriesForecastFewshotLoss.Mse,
                "rmse" => SingleSeriesForecastFewshotLoss.Rmse,
                "smape" => SingleSeriesForecastFewshotLoss.Smape,
                _ => null,
            };
        }
    }
}