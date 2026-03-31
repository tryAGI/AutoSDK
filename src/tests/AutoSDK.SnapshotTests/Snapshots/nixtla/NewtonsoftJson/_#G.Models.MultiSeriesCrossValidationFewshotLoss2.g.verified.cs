//HintName: G.Models.MultiSeriesCrossValidationFewshotLoss2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MultiSeriesCrossValidationFewshotLoss2
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
    public static class MultiSeriesCrossValidationFewshotLoss2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiSeriesCrossValidationFewshotLoss2 value)
        {
            return value switch
            {
                MultiSeriesCrossValidationFewshotLoss2.Default => "default",
                MultiSeriesCrossValidationFewshotLoss2.Mae => "mae",
                MultiSeriesCrossValidationFewshotLoss2.Mape => "mape",
                MultiSeriesCrossValidationFewshotLoss2.Mse => "mse",
                MultiSeriesCrossValidationFewshotLoss2.Rmse => "rmse",
                MultiSeriesCrossValidationFewshotLoss2.Smape => "smape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiSeriesCrossValidationFewshotLoss2? ToEnum(string value)
        {
            return value switch
            {
                "default" => MultiSeriesCrossValidationFewshotLoss2.Default,
                "mae" => MultiSeriesCrossValidationFewshotLoss2.Mae,
                "mape" => MultiSeriesCrossValidationFewshotLoss2.Mape,
                "mse" => MultiSeriesCrossValidationFewshotLoss2.Mse,
                "rmse" => MultiSeriesCrossValidationFewshotLoss2.Rmse,
                "smape" => MultiSeriesCrossValidationFewshotLoss2.Smape,
                _ => null,
            };
        }
    }
}