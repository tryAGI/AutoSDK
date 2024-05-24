//HintName: G.Models.JobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// <br/>Example: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobStepsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }
}