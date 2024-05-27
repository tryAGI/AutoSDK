//HintName: G.Models.MigrationsUpdateImportRequestVcs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of version control system you are migrating from.
    /// <br/>Example: "git"
    /// </summary>
    public abstract class MigrationsUpdateImportRequestVcs
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Subversion = "subversion";
        /// <summary>
        /// 
        /// </summary>
        public const string Tfvc = "tfvc";
        /// <summary>
        /// 
        /// </summary>
        public const string Git = "git";
        /// <summary>
        /// 
        /// </summary>
        public const string Mercurial = "mercurial";
    }
}