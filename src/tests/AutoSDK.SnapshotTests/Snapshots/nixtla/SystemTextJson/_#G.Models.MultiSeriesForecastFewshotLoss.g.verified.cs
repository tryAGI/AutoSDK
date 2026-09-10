//HintName: G.Models.MultiSeriesForecastFewshotLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MultiSeriesForecastFewshotLoss
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
    public static class MultiSeriesForecastFewshotLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesForecastFewshotLoss value)
        {
            return value switch
            {
                MultiSeriesForecastFewshotLoss.Default => "default",
                MultiSeriesForecastFewshotLoss.Mae => "mae",
                MultiSeriesForecastFewshotLoss.Mape => "mape",
                MultiSeriesForecastFewshotLoss.Mse => "mse",
                MultiSeriesForecastFewshotLoss.Rmse => "rmse",
                MultiSeriesForecastFewshotLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesForecastFewshotLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesForecastFewshotLoss.Default,
                "mae" => MultiSeriesForecastFewshotLoss.Mae,
                "mape" => MultiSeriesForecastFewshotLoss.Mape,
                "mse" => MultiSeriesForecastFewshotLoss.Mse,
                "rmse" => MultiSeriesForecastFewshotLoss.Rmse,
                "smape" => MultiSeriesForecastFewshotLoss.Smape,
                _ => null,
            };
        }
    }
}