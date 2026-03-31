//HintName: G.Models.SingleSeriesForecastFewshotLoss2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SingleSeriesForecastFewshotLoss2
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Mae,
        /// <summary>
        /// 
        /// </summary>
        Mape,
        /// <summary>
        /// 
        /// </summary>
        Mse,
        /// <summary>
        /// 
        /// </summary>
        Rmse,
        /// <summary>
        /// 
        /// </summary>
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