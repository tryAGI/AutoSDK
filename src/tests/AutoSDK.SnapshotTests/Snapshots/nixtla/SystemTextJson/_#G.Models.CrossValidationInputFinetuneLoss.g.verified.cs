//HintName: G.Models.CrossValidationInputFinetuneLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum CrossValidationInputFinetuneLoss
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
        Poisson,
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
    public static class CrossValidationInputFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrossValidationInputFinetuneLoss value)
        {
            return value switch
            {
                CrossValidationInputFinetuneLoss.Default => "default",
                CrossValidationInputFinetuneLoss.Mae => "mae",
                CrossValidationInputFinetuneLoss.Mape => "mape",
                CrossValidationInputFinetuneLoss.Mse => "mse",
                CrossValidationInputFinetuneLoss.Poisson => "poisson",
                CrossValidationInputFinetuneLoss.Rmse => "rmse",
                CrossValidationInputFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrossValidationInputFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => CrossValidationInputFinetuneLoss.Default,
                "mae" => CrossValidationInputFinetuneLoss.Mae,
                "mape" => CrossValidationInputFinetuneLoss.Mape,
                "mse" => CrossValidationInputFinetuneLoss.Mse,
                "poisson" => CrossValidationInputFinetuneLoss.Poisson,
                "rmse" => CrossValidationInputFinetuneLoss.Rmse,
                "smape" => CrossValidationInputFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}