//HintName: G.Models.MultiSeriesCrossValidationFinetuneLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum MultiSeriesCrossValidationFinetuneLoss
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
    public static class MultiSeriesCrossValidationFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesCrossValidationFinetuneLoss value)
        {
            return value switch
            {
                MultiSeriesCrossValidationFinetuneLoss.Default => "default",
                MultiSeriesCrossValidationFinetuneLoss.Mae => "mae",
                MultiSeriesCrossValidationFinetuneLoss.Mape => "mape",
                MultiSeriesCrossValidationFinetuneLoss.Mse => "mse",
                MultiSeriesCrossValidationFinetuneLoss.Rmse => "rmse",
                MultiSeriesCrossValidationFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesCrossValidationFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesCrossValidationFinetuneLoss.Default,
                "mae" => MultiSeriesCrossValidationFinetuneLoss.Mae,
                "mape" => MultiSeriesCrossValidationFinetuneLoss.Mape,
                "mse" => MultiSeriesCrossValidationFinetuneLoss.Mse,
                "rmse" => MultiSeriesCrossValidationFinetuneLoss.Rmse,
                "smape" => MultiSeriesCrossValidationFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}