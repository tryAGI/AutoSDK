//HintName: G.Models.MigrationsUpdateImportRequestVcs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of version control system you are migrating from.<br/>
    /// Example: "git"
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MigrationsUpdateImportRequestVcsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MigrationsUpdateImportRequestVcs value)
        {
            return value switch
            {
                MigrationsUpdateImportRequestVcs.Subversion => "subversion",
                MigrationsUpdateImportRequestVcs.Tfvc => "tfvc",
                MigrationsUpdateImportRequestVcs.Git => "git",
                MigrationsUpdateImportRequestVcs.Mercurial => "mercurial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MigrationsUpdateImportRequestVcs? ToEnum(string value)
        {
            return value switch
            {
                "subversion" => MigrationsUpdateImportRequestVcs.Subversion,
                "tfvc" => MigrationsUpdateImportRequestVcs.Tfvc,
                "git" => MigrationsUpdateImportRequestVcs.Git,
                "mercurial" => MigrationsUpdateImportRequestVcs.Mercurial,
                _ => null,
            };
        }
    }
}