//HintName: G.Models.UserCreditsCreditProductBillingInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserCreditsCreditProductBillingInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="year")]
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserCreditsCreditProductBillingIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserCreditsCreditProductBillingInterval value)
        {
            return value switch
            {
                UserCreditsCreditProductBillingInterval.Month => "month",
                UserCreditsCreditProductBillingInterval.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserCreditsCreditProductBillingInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => UserCreditsCreditProductBillingInterval.Month,
                "year" => UserCreditsCreditProductBillingInterval.Year,
                _ => null,
            };
        }
    }
}