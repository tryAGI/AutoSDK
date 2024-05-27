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
    public abstract class EndPollBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string TERMINATED = "TERMINATED";
        /// <summary>
        /// 
        /// </summary>
        public const string ARCHIVED = "ARCHIVED";
    }
}