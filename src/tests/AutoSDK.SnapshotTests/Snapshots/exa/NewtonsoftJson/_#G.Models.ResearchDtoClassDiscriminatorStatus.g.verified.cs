//HintName: G.Models.ResearchDtoClassDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchDtoClassDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassDiscriminatorStatus value)
        {
            return value switch
            {
                ResearchDtoClassDiscriminatorStatus.Canceled => "canceled",
                ResearchDtoClassDiscriminatorStatus.Completed => "completed",
                ResearchDtoClassDiscriminatorStatus.Failed => "failed",
                ResearchDtoClassDiscriminatorStatus.Pending => "pending",
                ResearchDtoClassDiscriminatorStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ResearchDtoClassDiscriminatorStatus.Canceled,
                "completed" => ResearchDtoClassDiscriminatorStatus.Completed,
                "failed" => ResearchDtoClassDiscriminatorStatus.Failed,
                "pending" => ResearchDtoClassDiscriminatorStatus.Pending,
                "running" => ResearchDtoClassDiscriminatorStatus.Running,
                _ => null,
            };
        }
    }
}