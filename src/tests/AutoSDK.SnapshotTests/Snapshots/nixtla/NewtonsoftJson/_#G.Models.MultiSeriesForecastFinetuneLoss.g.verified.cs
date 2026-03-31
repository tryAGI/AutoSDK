//HintName: G.Models.MultiSeriesForecastFinetuneLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The loss used to train the large time model on the data. Select from ['default', 'mae', 'mse', 'rmse', 'mape', 'smape']. It will only be used if finetune_steps larger than 0. Default is a robust loss function that is less sensitive to outliers.<br/>
    /// Default Value: default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MultiSeriesForecastFinetuneLoss
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
    public static class MultiSeriesForecastFinetuneLossExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesForecastFinetuneLoss value)
        {
            return value switch
            {
                MultiSeriesForecastFinetuneLoss.Default => "default",
                MultiSeriesForecastFinetuneLoss.Mae => "mae",
                MultiSeriesForecastFinetuneLoss.Mape => "mape",
                MultiSeriesForecastFinetuneLoss.Mse => "mse",
                MultiSeriesForecastFinetuneLoss.Rmse => "rmse",
                MultiSeriesForecastFinetuneLoss.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesForecastFinetuneLoss? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesForecastFinetuneLoss.Default,
                "mae" => MultiSeriesForecastFinetuneLoss.Mae,
                "mape" => MultiSeriesForecastFinetuneLoss.Mape,
                "mse" => MultiSeriesForecastFinetuneLoss.Mse,
                "rmse" => MultiSeriesForecastFinetuneLoss.Rmse,
                "smape" => MultiSeriesForecastFinetuneLoss.Smape,
                _ => null,
            };
        }
    }
}