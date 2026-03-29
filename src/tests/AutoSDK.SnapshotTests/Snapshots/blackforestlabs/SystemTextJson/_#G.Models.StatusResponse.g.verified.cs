//HintName: G.Models.StatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        ContentModerated,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        RequestModerated,
        /// <summary>
        /// 
        /// </summary>
        TaskNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponse value)
        {
            return value switch
            {
                StatusResponse.ContentModerated => "Content Moderated",
                StatusResponse.Error => "Error",
                StatusResponse.Pending => "Pending",
                StatusResponse.Ready => "Ready",
                StatusResponse.RequestModerated => "Request Moderated",
                StatusResponse.TaskNotFound => "Task not found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponse? ToEnum(string value)
        {
            return value switch
            {
                "Content Moderated" => StatusResponse.ContentModerated,
                "Error" => StatusResponse.Error,
                "Pending" => StatusResponse.Pending,
                "Ready" => StatusResponse.Ready,
                "Request Moderated" => StatusResponse.RequestModerated,
                "Task not found" => StatusResponse.TaskNotFound,
                _ => null,
            };
        }
    }
}