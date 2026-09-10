//HintName: G.Models.MultiSeriesCrossValidationFewshotLoss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MultiSeriesCrossValidationFewshotLoss
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