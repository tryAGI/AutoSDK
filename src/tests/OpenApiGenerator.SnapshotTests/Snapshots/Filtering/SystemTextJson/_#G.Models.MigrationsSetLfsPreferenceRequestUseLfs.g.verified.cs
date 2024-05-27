//HintName: G.Models.MigrationsSetLfsPreferenceRequestUseLfs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
    /// </summary>
    public abstract class MigrationsSetLfsPreferenceRequestUseLfs
    {
        /// <summary>
        /// 
        /// </summary>
        public const string OptIn = "opt_in";
        /// <summary>
        /// 
        /// </summary>
        public const string OptOut = "opt_out";
    }
}