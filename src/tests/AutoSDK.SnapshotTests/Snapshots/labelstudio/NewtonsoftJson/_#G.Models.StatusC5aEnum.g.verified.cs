//HintName: G.Models.StatusC5aEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `initialized` - Initialized<br/>
    /// * `queued` - Queued<br/>
    /// * `in_progress` - In progress<br/>
    /// * `failed` - Failed<br/>
    /// * `completed` - Completed<br/>
    /// * `completed_with_errors` - Completed with errors
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StatusC5aEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed_with_errors")]
        CompletedWithErrors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initialized")]
        Initialized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusC5aEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusC5aEnum value)
        {
            return value switch
            {
                StatusC5aEnum.Completed => "completed",
                StatusC5aEnum.CompletedWithErrors => "completed_with_errors",
                StatusC5aEnum.Failed => "failed",
                StatusC5aEnum.InProgress => "in_progress",
                StatusC5aEnum.Initialized => "initialized",
                StatusC5aEnum.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusC5aEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => StatusC5aEnum.Completed,
                "completed_with_errors" => StatusC5aEnum.CompletedWithErrors,
                "failed" => StatusC5aEnum.Failed,
                "in_progress" => StatusC5aEnum.InProgress,
                "initialized" => StatusC5aEnum.Initialized,
                "queued" => StatusC5aEnum.Queued,
                _ => null,
            };
        }
    }
}