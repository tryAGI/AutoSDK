//HintName: G.Models.ListCallsRequestFilterCriteriaCallStatu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCallsRequestFilterCriteriaCallStatu
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_connected")]
        NotConnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ongoing")]
        Ongoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsRequestFilterCriteriaCallStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsRequestFilterCriteriaCallStatu value)
        {
            return value switch
            {
                ListCallsRequestFilterCriteriaCallStatu.Ended => "ended",
                ListCallsRequestFilterCriteriaCallStatu.Error => "error",
                ListCallsRequestFilterCriteriaCallStatu.NotConnected => "not_connected",
                ListCallsRequestFilterCriteriaCallStatu.Ongoing => "ongoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsRequestFilterCriteriaCallStatu? ToEnum(string value)
        {
            return value switch
            {
                "ended" => ListCallsRequestFilterCriteriaCallStatu.Ended,
                "error" => ListCallsRequestFilterCriteriaCallStatu.Error,
                "not_connected" => ListCallsRequestFilterCriteriaCallStatu.NotConnected,
                "ongoing" => ListCallsRequestFilterCriteriaCallStatu.Ongoing,
                _ => null,
            };
        }
    }
}