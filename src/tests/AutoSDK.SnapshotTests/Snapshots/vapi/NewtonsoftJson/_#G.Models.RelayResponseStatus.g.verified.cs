//HintName: G.Models.RelayResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the relay request
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RelayResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deliveredHeadless")]
        DeliveredHeadless,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deliveredLive")]
        DeliveredLive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayResponseStatus value)
        {
            return value switch
            {
                RelayResponseStatus.DeliveredHeadless => "deliveredHeadless",
                RelayResponseStatus.DeliveredLive => "deliveredLive",
                RelayResponseStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "deliveredHeadless" => RelayResponseStatus.DeliveredHeadless,
                "deliveredLive" => RelayResponseStatus.DeliveredLive,
                "failed" => RelayResponseStatus.Failed,
                _ => null,
            };
        }
    }
}