//HintName: G.Models.ServerMessageEndOfCallReportType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageEndOfCallReportType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end-of-call-report")]
        EndOfCallReport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageEndOfCallReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageEndOfCallReportType value)
        {
            return value switch
            {
                ServerMessageEndOfCallReportType.EndOfCallReport => "end-of-call-report",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageEndOfCallReportType? ToEnum(string value)
        {
            return value switch
            {
                "end-of-call-report" => ServerMessageEndOfCallReportType.EndOfCallReport,
                _ => null,
            };
        }
    }
}