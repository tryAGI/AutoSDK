//HintName: G.Models.SingleSeriesForecastFewshotLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SingleSeriesForecastFewshotLoss
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