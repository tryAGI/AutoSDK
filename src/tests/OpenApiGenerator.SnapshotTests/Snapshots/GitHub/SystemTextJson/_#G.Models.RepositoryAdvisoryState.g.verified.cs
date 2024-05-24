//HintName: G.Models.RepositoryAdvisoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the advisory.
    /// </summary>
    public abstract class RepositoryAdvisoryState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Published = "published";
        /// <summary>
        /// 
        /// </summary>
        public const string Closed = "closed";
        /// <summary>
        /// 
        /// </summary>
        public const string Withdrawn = "withdrawn";
        /// <summary>
        /// 
        /// </summary>
        public const string Draft = "draft";
        /// <summary>
        /// 
        /// </summary>
        public const string Triage = "triage";
    }
}