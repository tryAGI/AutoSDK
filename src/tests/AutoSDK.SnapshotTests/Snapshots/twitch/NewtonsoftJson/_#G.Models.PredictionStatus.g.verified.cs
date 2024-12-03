//HintName: G.Models.PredictionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The prediction’s status. Valid values are:  <br/>
    ///   <br/>
    /// * ACTIVE — The Prediction is running and viewers can make predictions.<br/>
    /// * CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.<br/>
    /// * LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.<br/>
    /// * RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        ACTIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOCKED")]
        LOCKED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RESOLVED")]
        RESOLVED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionStatus value)
        {
            return value switch
            {
                PredictionStatus.ACTIVE => "ACTIVE",
                PredictionStatus.CANCELED => "CANCELED",
                PredictionStatus.LOCKED => "LOCKED",
                PredictionStatus.RESOLVED => "RESOLVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PredictionStatus.ACTIVE,
                "CANCELED" => PredictionStatus.CANCELED,
                "LOCKED" => PredictionStatus.LOCKED,
                "RESOLVED" => PredictionStatus.RESOLVED,
                _ => null,
            };
        }
    }
}