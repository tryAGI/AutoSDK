//HintName: G.Models.MigrationsUpdateImportRequestVcs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of version control system you are migrating from.
    /// <br/>Example: "git"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MigrationsUpdateImportRequestVcs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subversion")]
        Subversion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tfvc")]
        Tfvc,
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
    }
}