//HintName: G.Models.EndPollBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the poll to. Possible case-sensitive values are:  
    ///   
    /// * TERMINATED — Ends the poll before the poll is scheduled to end. The poll remains publicly visible.
    /// * ARCHIVED — Ends the poll before the poll is scheduled to end, and then archives it so it's no longer publicly visible.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EndPollBodyStatus
    {
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
    }
}