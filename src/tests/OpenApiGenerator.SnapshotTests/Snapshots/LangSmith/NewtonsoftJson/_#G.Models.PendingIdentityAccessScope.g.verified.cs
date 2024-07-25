//HintName: G.Models.PendingIdentityAccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PendingIdentityAccessScope
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
    public static class PendingIdentityAccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingIdentityAccessScope value)
        {
            return value switch
            {
                PendingIdentityAccessScope.Organization => "organization",
                PendingIdentityAccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingIdentityAccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => PendingIdentityAccessScope.Organization,
                "workspace" => PendingIdentityAccessScope.Workspace,
                _ => null,
            };
        }
    }
}