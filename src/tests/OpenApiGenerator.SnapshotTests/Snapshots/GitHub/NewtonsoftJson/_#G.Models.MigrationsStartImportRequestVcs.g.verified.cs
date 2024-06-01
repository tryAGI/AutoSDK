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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsStartImportRequestVcsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
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
    }
}