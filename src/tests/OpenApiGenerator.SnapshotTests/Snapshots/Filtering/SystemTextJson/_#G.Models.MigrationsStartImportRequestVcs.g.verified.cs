//HintName: G.Models.MigrationsStartImportRequestVcs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
    /// </summary>
    public abstract class MigrationsStartImportRequestVcs
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Subversion = "subversion";
        /// <summary>
        /// 
        /// </summary>
        public const string Git = "git";
        /// <summary>
        /// 
        /// </summary>
        public const string Mercurial = "mercurial";
        /// <summary>
        /// 
        /// </summary>
        public const string Tfvc = "tfvc";
    }
}