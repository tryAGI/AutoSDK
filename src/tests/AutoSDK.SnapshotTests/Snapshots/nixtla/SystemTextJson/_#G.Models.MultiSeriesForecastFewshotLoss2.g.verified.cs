//HintName: G.Models.MultiSeriesForecastFewshotLoss2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MultiSeriesForecastFewshotLoss2
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
    public static class MultiSeriesForecastFewshotLoss2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesForecastFewshotLoss2 value)
        {
            return value switch
            {
                MultiSeriesForecastFewshotLoss2.Default => "default",
                MultiSeriesForecastFewshotLoss2.Mae => "mae",
                MultiSeriesForecastFewshotLoss2.Mape => "mape",
                MultiSeriesForecastFewshotLoss2.Mse => "mse",
                MultiSeriesForecastFewshotLoss2.Rmse => "rmse",
                MultiSeriesForecastFewshotLoss2.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesForecastFewshotLoss2? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesForecastFewshotLoss2.Default,
                "mae" => MultiSeriesForecastFewshotLoss2.Mae,
                "mape" => MultiSeriesForecastFewshotLoss2.Mape,
                "mse" => MultiSeriesForecastFewshotLoss2.Mse,
                "rmse" => MultiSeriesForecastFewshotLoss2.Rmse,
                "smape" => MultiSeriesForecastFewshotLoss2.Smape,
                _ => null,
            };
        }
    }
}