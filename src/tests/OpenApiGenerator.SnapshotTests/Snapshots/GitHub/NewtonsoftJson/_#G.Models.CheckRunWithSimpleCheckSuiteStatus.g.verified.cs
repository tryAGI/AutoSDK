//HintName: G.Models.CheckRunWithSimpleCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check is currently in.
    /// <br/>Example: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckRunWithSimpleCheckSuiteStatus
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }
}