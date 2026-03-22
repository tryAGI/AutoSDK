//HintName: G.Models.CorpusRoleRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role assigned for this specific corpus.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CorpusRoleRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="administrator")]
        Administrator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="editor")]
        Editor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="viewer")]
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CorpusRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CorpusRoleRole value)
        {
            return value switch
            {
                CorpusRoleRole.Administrator => "administrator",
                CorpusRoleRole.Editor => "editor",
                CorpusRoleRole.Owner => "owner",
                CorpusRoleRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CorpusRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "administrator" => CorpusRoleRole.Administrator,
                "editor" => CorpusRoleRole.Editor,
                "owner" => CorpusRoleRole.Owner,
                "viewer" => CorpusRoleRole.Viewer,
                _ => null,
            };
        }
    }
}