//HintName: G.Models.PullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// <br/>Example: open
    /// </summary>
    public abstract class PullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Open = "open";
        /// <summary>
        /// 
        /// </summary>
        public const string Closed = "closed";
    }
}