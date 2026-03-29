//HintName: G.Models.ServerlessLogsStreamRunSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by run source<br/>
    /// Example: grpc-run
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessLogsStreamRunSource
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
    public static class ServerlessLogsStreamRunSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamRunSource value)
        {
            return value switch
            {
                ServerlessLogsStreamRunSource.Cron => "cron",
                ServerlessLogsStreamRunSource.Gateway => "gateway",
                ServerlessLogsStreamRunSource.GrpcRegister => "grpc-register",
                ServerlessLogsStreamRunSource.GrpcRun => "grpc-run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamRunSource? ToEnum(string value)
        {
            return value switch
            {
                "cron" => ServerlessLogsStreamRunSource.Cron,
                "gateway" => ServerlessLogsStreamRunSource.Gateway,
                "grpc-register" => ServerlessLogsStreamRunSource.GrpcRegister,
                "grpc-run" => ServerlessLogsStreamRunSource.GrpcRun,
                _ => null,
            };
        }
    }
}