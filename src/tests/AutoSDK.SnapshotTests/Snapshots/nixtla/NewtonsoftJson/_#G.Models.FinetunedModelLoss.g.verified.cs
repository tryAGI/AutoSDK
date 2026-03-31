//HintName: G.Models.FinetunedModelLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetunedModelLoss
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
        [global::System.Runtime.Serialization.EnumMember(Value="poisson")]
        Poisson,
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