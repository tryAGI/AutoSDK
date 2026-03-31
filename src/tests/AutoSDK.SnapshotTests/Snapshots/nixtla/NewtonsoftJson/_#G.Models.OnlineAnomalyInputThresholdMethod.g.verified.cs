//HintName: G.Models.OnlineAnomalyInputThresholdMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The thresholding method to detect anomalies<br/>
    /// Default Value: univariate
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OnlineAnomalyInputThresholdMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multivariate")]
        Multivariate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="univariate")]
        Univariate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnlineAnomalyInputThresholdMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnlineAnomalyInputThresholdMethod value)
        {
            return value switch
            {
                OnlineAnomalyInputThresholdMethod.Multivariate => "multivariate",
                OnlineAnomalyInputThresholdMethod.Univariate => "univariate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnlineAnomalyInputThresholdMethod? ToEnum(string value)
        {
            return value switch
            {
                "multivariate" => OnlineAnomalyInputThresholdMethod.Multivariate,
                "univariate" => OnlineAnomalyInputThresholdMethod.Univariate,
                _ => null,
            };
        }
    }
}