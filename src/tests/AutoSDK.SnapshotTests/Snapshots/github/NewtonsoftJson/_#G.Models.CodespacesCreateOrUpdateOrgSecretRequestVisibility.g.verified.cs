//HintName: G.Models.CodespacesCreateOrUpdateOrgSecretRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesCreateOrUpdateOrgSecretRequestVisibility
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
    public static class CodespacesCreateOrUpdateOrgSecretRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateOrUpdateOrgSecretRequestVisibility value)
        {
            return value switch
            {
                CodespacesCreateOrUpdateOrgSecretRequestVisibility.All => "all",
                CodespacesCreateOrUpdateOrgSecretRequestVisibility.Private => "private",
                CodespacesCreateOrUpdateOrgSecretRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateOrUpdateOrgSecretRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodespacesCreateOrUpdateOrgSecretRequestVisibility.All,
                "private" => CodespacesCreateOrUpdateOrgSecretRequestVisibility.Private,
                "selected" => CodespacesCreateOrUpdateOrgSecretRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}