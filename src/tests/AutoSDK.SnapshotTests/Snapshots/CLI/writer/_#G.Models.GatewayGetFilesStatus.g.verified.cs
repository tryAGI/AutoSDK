//HintName: G.Models.GatewayGetFilesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GatewayGetFilesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayGetFilesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayGetFilesStatus value)
        {
            return value switch
            {
                GatewayGetFilesStatus.Completed => "completed",
                GatewayGetFilesStatus.Failed => "failed",
                GatewayGetFilesStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayGetFilesStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GatewayGetFilesStatus.Completed,
                "failed" => GatewayGetFilesStatus.Failed,
                "in_progress" => GatewayGetFilesStatus.InProgress,
                _ => null,
            };
        }
    }
}