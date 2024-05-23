//HintName: G.Models.PageProtectedDomainState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state if the domain is verified
    /// <br/>Example: pending
    /// </summary>
    public abstract class PageProtectedDomainState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
        /// <summary>
        /// 
        /// </summary>
        public const string Verified = "verified";
        /// <summary>
        /// 
        /// </summary>
        public const string Unverified = "unverified";
    }
}