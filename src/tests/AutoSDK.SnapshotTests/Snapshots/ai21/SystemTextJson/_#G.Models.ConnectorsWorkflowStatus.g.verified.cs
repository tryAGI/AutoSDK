//HintName: G.Models.ConnectorsWorkflowStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ConnectorsWorkflowStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        PartiallyCompleted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorsWorkflowStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorsWorkflowStatus value)
        {
            return value switch
            {
                ConnectorsWorkflowStatus.InProgress => "IN_PROGRESS",
                ConnectorsWorkflowStatus.PartiallyCompleted => "PARTIALLY_COMPLETED",
                ConnectorsWorkflowStatus.Failed => "FAILED",
                ConnectorsWorkflowStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorsWorkflowStatus? ToEnum(string value)
        {
            return value switch
            {
                "IN_PROGRESS" => ConnectorsWorkflowStatus.InProgress,
                "PARTIALLY_COMPLETED" => ConnectorsWorkflowStatus.PartiallyCompleted,
                "FAILED" => ConnectorsWorkflowStatus.Failed,
                "SUCCEEDED" => ConnectorsWorkflowStatus.Succeeded,
                _ => null,
            };
        }
    }
}