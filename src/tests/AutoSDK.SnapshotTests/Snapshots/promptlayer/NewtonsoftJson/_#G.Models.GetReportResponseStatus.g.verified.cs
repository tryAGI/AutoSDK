//HintName: G.Models.GetReportResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overall status of the report execution
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetReportResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetReportResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetReportResponseStatus value)
        {
            return value switch
            {
                GetReportResponseStatus.Completed => "COMPLETED",
                GetReportResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetReportResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => GetReportResponseStatus.Completed,
                "RUNNING" => GetReportResponseStatus.Running,
                _ => null,
            };
        }
    }
}