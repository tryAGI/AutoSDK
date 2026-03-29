//HintName: G.Models.ServerlessLogsHistoryRunSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by run source<br/>
    /// Example: grpc-run
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessLogsHistoryRunSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cron")]
        Cron,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gateway")]
        Gateway,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grpc-register")]
        GrpcRegister,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grpc-run")]
        GrpcRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsHistoryRunSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryRunSource value)
        {
            return value switch
            {
                ServerlessLogsHistoryRunSource.Cron => "cron",
                ServerlessLogsHistoryRunSource.Gateway => "gateway",
                ServerlessLogsHistoryRunSource.GrpcRegister => "grpc-register",
                ServerlessLogsHistoryRunSource.GrpcRun => "grpc-run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryRunSource? ToEnum(string value)
        {
            return value switch
            {
                "cron" => ServerlessLogsHistoryRunSource.Cron,
                "gateway" => ServerlessLogsHistoryRunSource.Gateway,
                "grpc-register" => ServerlessLogsHistoryRunSource.GrpcRegister,
                "grpc-run" => ServerlessLogsHistoryRunSource.GrpcRun,
                _ => null,
            };
        }
    }
}