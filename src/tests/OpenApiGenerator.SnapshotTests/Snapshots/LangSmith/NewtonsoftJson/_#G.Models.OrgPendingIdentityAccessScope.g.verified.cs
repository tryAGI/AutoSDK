//HintName: G.Models.OrgPendingIdentityAccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgPendingIdentityAccessScope
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
    public static class OrgPendingIdentityAccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPendingIdentityAccessScope value)
        {
            return value switch
            {
                OrgPendingIdentityAccessScope.Organization => "organization",
                OrgPendingIdentityAccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPendingIdentityAccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => OrgPendingIdentityAccessScope.Organization,
                "workspace" => OrgPendingIdentityAccessScope.Workspace,
                _ => null,
            };
        }
    }
}