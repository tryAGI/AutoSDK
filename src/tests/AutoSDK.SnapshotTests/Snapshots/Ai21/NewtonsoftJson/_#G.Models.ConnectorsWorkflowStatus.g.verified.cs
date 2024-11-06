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
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        INPROGRESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIALLY_COMPLETED")]
        PARTIALLYCOMPLETED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
        SUCCEEDED,
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
                ConnectorsWorkflowStatus.INPROGRESS => "IN_PROGRESS",
                ConnectorsWorkflowStatus.PARTIALLYCOMPLETED => "PARTIALLY_COMPLETED",
                ConnectorsWorkflowStatus.FAILED => "FAILED",
                ConnectorsWorkflowStatus.SUCCEEDED => "SUCCEEDED",
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
                "IN_PROGRESS" => ConnectorsWorkflowStatus.INPROGRESS,
                "PARTIALLY_COMPLETED" => ConnectorsWorkflowStatus.PARTIALLYCOMPLETED,
                "FAILED" => ConnectorsWorkflowStatus.FAILED,
                "SUCCEEDED" => ConnectorsWorkflowStatus.SUCCEEDED,
                _ => null,
            };
        }
    }
}