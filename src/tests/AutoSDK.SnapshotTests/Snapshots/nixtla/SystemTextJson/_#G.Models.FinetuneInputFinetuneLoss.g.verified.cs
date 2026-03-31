//HintName: G.Models.FinetuneInputFinetuneLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    public enum FinetuneInputFinetuneLoss
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
    public static class FinetuneInputFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneInputFinetuneLoss value)
        {
            return value switch
            {
                FinetuneInputFinetuneLoss.Default => "default",
                FinetuneInputFinetuneLoss.Mae => "mae",
                FinetuneInputFinetuneLoss.Mape => "mape",
                FinetuneInputFinetuneLoss.Mse => "mse",
                FinetuneInputFinetuneLoss.Poisson => "poisson",
                FinetuneInputFinetuneLoss.Rmse => "rmse",
                FinetuneInputFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneInputFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => FinetuneInputFinetuneLoss.Default,
                "mae" => FinetuneInputFinetuneLoss.Mae,
                "mape" => FinetuneInputFinetuneLoss.Mape,
                "mse" => FinetuneInputFinetuneLoss.Mse,
                "poisson" => FinetuneInputFinetuneLoss.Poisson,
                "rmse" => FinetuneInputFinetuneLoss.Rmse,
                "smape" => FinetuneInputFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}