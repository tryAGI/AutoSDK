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

    public static class MigrationsStartImportRequestVcsExtensions
    {
        public static string ToValueString(this MigrationsStartImportRequestVcs value)
        {
            return value switch
            {
                MigrationsStartImportRequestVcs.Subversion => "subversion",
                MigrationsStartImportRequestVcs.Git => "git",
                MigrationsStartImportRequestVcs.Mercurial => "mercurial",
                MigrationsStartImportRequestVcs.Tfvc => "tfvc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartImportRequestVcs ToEnum(string value)
        {
            return value switch
            {
                "subversion" => MigrationsStartImportRequestVcs.Subversion,
                "git" => MigrationsStartImportRequestVcs.Git,
                "mercurial" => MigrationsStartImportRequestVcs.Mercurial,
                "tfvc" => MigrationsStartImportRequestVcs.Tfvc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MigrationsStartImportRequestVcs ToEnum(int value)
        {
            return value switch
            {
                0 => MigrationsStartImportRequestVcs.Subversion,
                1 => MigrationsStartImportRequestVcs.Git,
                2 => MigrationsStartImportRequestVcs.Mercurial,
                3 => MigrationsStartImportRequestVcs.Tfvc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}