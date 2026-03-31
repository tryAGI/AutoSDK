//HintName: G.Models.FinetunedModelLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetunedModelLoss
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
    public static class FinetunedModelLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetunedModelLoss value)
        {
            return value switch
            {
                FinetunedModelLoss.Default => "default",
                FinetunedModelLoss.Mae => "mae",
                FinetunedModelLoss.Mape => "mape",
                FinetunedModelLoss.Mse => "mse",
                FinetunedModelLoss.Poisson => "poisson",
                FinetunedModelLoss.Rmse => "rmse",
                FinetunedModelLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetunedModelLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => FinetunedModelLoss.Default,
                "mae" => FinetunedModelLoss.Mae,
                "mape" => FinetunedModelLoss.Mape,
                "mse" => FinetunedModelLoss.Mse,
                "poisson" => FinetunedModelLoss.Poisson,
                "rmse" => FinetunedModelLoss.Rmse,
                "smape" => FinetunedModelLoss.Smape,
                _ => null,
            };
        }
    }
}