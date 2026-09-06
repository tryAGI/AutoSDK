//HintName: G.Models.MultiSeriesCrossValidationFewshotLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MultiSeriesCrossValidationFewshotLoss
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
    public static class MultiSeriesCrossValidationFewshotLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesCrossValidationFewshotLoss value)
        {
            return value switch
            {
                MultiSeriesCrossValidationFewshotLoss.Default => "default",
                MultiSeriesCrossValidationFewshotLoss.Mae => "mae",
                MultiSeriesCrossValidationFewshotLoss.Mape => "mape",
                MultiSeriesCrossValidationFewshotLoss.Mse => "mse",
                MultiSeriesCrossValidationFewshotLoss.Rmse => "rmse",
                MultiSeriesCrossValidationFewshotLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesCrossValidationFewshotLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesCrossValidationFewshotLoss.Default,
                "mae" => MultiSeriesCrossValidationFewshotLoss.Mae,
                "mape" => MultiSeriesCrossValidationFewshotLoss.Mape,
                "mse" => MultiSeriesCrossValidationFewshotLoss.Mse,
                "rmse" => MultiSeriesCrossValidationFewshotLoss.Rmse,
                "smape" => MultiSeriesCrossValidationFewshotLoss.Smape,
                _ => null,
            };
        }
    }
}