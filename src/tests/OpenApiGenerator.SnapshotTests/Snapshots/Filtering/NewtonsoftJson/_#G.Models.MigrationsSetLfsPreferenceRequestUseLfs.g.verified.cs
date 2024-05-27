//HintName: G.Models.MigrationsSetLfsPreferenceRequestUseLfs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsSetLfsPreferenceRequestUseLfs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opt_in")]
        OptIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opt_out")]
        OptOut,
    }
}