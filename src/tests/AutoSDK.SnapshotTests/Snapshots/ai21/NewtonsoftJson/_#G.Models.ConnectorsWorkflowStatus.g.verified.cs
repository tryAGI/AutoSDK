//HintName: G.Models.ConnectorsWorkflowStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConnectorsWorkflowStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIALLY_COMPLETED")]
        PartiallyCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
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
                ConnectorsWorkflowStatus.Failed => "FAILED",
                ConnectorsWorkflowStatus.InProgress => "IN_PROGRESS",
                ConnectorsWorkflowStatus.PartiallyCompleted => "PARTIALLY_COMPLETED",
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
                "FAILED" => ConnectorsWorkflowStatus.Failed,
                "IN_PROGRESS" => ConnectorsWorkflowStatus.InProgress,
                "PARTIALLY_COMPLETED" => ConnectorsWorkflowStatus.PartiallyCompleted,
                "SUCCEEDED" => ConnectorsWorkflowStatus.Succeeded,
                _ => null,
            };
        }
    }
}