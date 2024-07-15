//HintName: G.Models.CodespacesOrgSecretVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories in the organization that the secret is visible to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesOrgSecretVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespacesOrgSecretVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesOrgSecretVisibility value)
        {
            return value switch
            {
                CodespacesOrgSecretVisibility.All => "all",
                CodespacesOrgSecretVisibility.Private => "private",
                CodespacesOrgSecretVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesOrgSecretVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodespacesOrgSecretVisibility.All,
                "private" => CodespacesOrgSecretVisibility.Private,
                "selected" => CodespacesOrgSecretVisibility.Selected,
                _ => null,
            };
        }
    }
}