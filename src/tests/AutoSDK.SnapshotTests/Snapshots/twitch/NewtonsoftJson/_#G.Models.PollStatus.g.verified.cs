//HintName: G.Models.PollStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The poll’s status. Valid values are:  <br/>
    ///   <br/>
    /// * ACTIVE — The poll is running.<br/>
    /// * COMPLETED — The poll ended on schedule (see the `duration` field).<br/>
    /// * TERMINATED — The poll was terminated before its scheduled end.<br/>
    /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.<br/>
    /// * MODERATED — The poll was deleted.<br/>
    /// * INVALID — Something went wrong while determining the state.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PollStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        ACTIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        COMPLETED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TERMINATED")]
        TERMINATED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ARCHIVED")]
        ARCHIVED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MODERATED")]
        MODERATED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INVALID")]
        INVALID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollStatus value)
        {
            return value switch
            {
                PollStatus.ACTIVE => "ACTIVE",
                PollStatus.COMPLETED => "COMPLETED",
                PollStatus.TERMINATED => "TERMINATED",
                PollStatus.ARCHIVED => "ARCHIVED",
                PollStatus.MODERATED => "MODERATED",
                PollStatus.INVALID => "INVALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PollStatus.ACTIVE,
                "COMPLETED" => PollStatus.COMPLETED,
                "TERMINATED" => PollStatus.TERMINATED,
                "ARCHIVED" => PollStatus.ARCHIVED,
                "MODERATED" => PollStatus.MODERATED,
                "INVALID" => PollStatus.INVALID,
                _ => null,
            };
        }
    }
}