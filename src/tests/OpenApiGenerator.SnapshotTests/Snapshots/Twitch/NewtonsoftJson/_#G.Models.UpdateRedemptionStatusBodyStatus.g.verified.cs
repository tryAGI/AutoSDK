//HintName: G.Models.UpdateRedemptionStatusBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the redemption to. Possible values are:  
    ///   
    /// * CANCELED
    /// * FULFILLED
    ///   
    /// Setting the status to CANCELED refunds the user’s channel points.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateRedemptionStatusBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        FULFILLED,
    }

    public static class UpdateRedemptionStatusBodyStatusExtensions
    {
        public static string ToValueString(this UpdateRedemptionStatusBodyStatus value)
        {
            return value switch
            {
                UpdateRedemptionStatusBodyStatus.CANCELED => "CANCELED",
                UpdateRedemptionStatusBodyStatus.FULFILLED => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateRedemptionStatusBodyStatus ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => UpdateRedemptionStatusBodyStatus.CANCELED,
                "FULFILLED" => UpdateRedemptionStatusBodyStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateRedemptionStatusBodyStatus ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateRedemptionStatusBodyStatus.CANCELED,
                1 => UpdateRedemptionStatusBodyStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}