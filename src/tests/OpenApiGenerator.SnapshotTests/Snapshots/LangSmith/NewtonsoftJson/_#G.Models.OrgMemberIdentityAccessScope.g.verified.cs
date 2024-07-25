//HintName: G.Models.OrgMemberIdentityAccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgMemberIdentityAccessScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgMemberIdentityAccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgMemberIdentityAccessScope value)
        {
            return value switch
            {
                OrgMemberIdentityAccessScope.Organization => "organization",
                OrgMemberIdentityAccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgMemberIdentityAccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrgMemberIdentityAccessScope.Organization,
                "workspace" => OrgMemberIdentityAccessScope.Workspace,
                _ => null,
            };
        }
    }
}