//HintName: G.Models.PageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the most recent build of the Page.
    /// <br/>Example: built
    /// </summary>
    public abstract class PageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Built = "built";
        /// <summary>
        /// 
        /// </summary>
        public const string Building = "building";
        /// <summary>
        /// 
        /// </summary>
        public const string Errored = "errored";
    }
}