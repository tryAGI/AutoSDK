//HintName: G.Models.MigrationsStartImportRequestVcs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsStartImportRequestVcs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subversion")]
        Subversion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="git")]
        Git,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mercurial")]
        Mercurial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tfvc")]
        Tfvc,
    }
}