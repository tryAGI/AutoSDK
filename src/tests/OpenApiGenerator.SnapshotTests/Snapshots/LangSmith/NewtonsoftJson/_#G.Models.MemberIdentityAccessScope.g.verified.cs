//HintName: G.Models.MemberIdentityAccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MemberIdentityAccessScope
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
    public static class MemberIdentityAccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemberIdentityAccessScope value)
        {
            return value switch
            {
                MemberIdentityAccessScope.Organization => "organization",
                MemberIdentityAccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemberIdentityAccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => MemberIdentityAccessScope.Organization,
                "workspace" => MemberIdentityAccessScope.Workspace,
                _ => null,
            };
        }
    }
}