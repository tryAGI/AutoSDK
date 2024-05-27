//HintName: G.Models.PollStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The poll’s status. Valid values are:  
    ///   
    /// * ACTIVE — The poll is running.
    /// * COMPLETED — The poll ended on schedule (see the `duration` field).
    /// * TERMINATED — The poll was terminated before its scheduled end.
    /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.
    /// * MODERATED — The poll was deleted.
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
}