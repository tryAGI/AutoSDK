//HintName: G.Models.ServerlessListRequestsByEndpointStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by request status<br/>
    /// Example: success
    /// </summary>
    public enum ServerlessListRequestsByEndpointStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListRequestsByEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointStatus value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointStatus.Error => "error",
                ServerlessListRequestsByEndpointStatus.Success => "success",
                ServerlessListRequestsByEndpointStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ServerlessListRequestsByEndpointStatus.Error,
                "success" => ServerlessListRequestsByEndpointStatus.Success,
                "user_error" => ServerlessListRequestsByEndpointStatus.UserError,
                _ => null,
            };
        }
    }
}