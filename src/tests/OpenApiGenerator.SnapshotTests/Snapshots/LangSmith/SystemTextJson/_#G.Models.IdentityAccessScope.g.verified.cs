//HintName: G.Models.IdentityAccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentityAccessScope
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityAccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityAccessScope value)
        {
            return value switch
            {
                IdentityAccessScope.Organization => "organization",
                IdentityAccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityAccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => IdentityAccessScope.Organization,
                "workspace" => IdentityAccessScope.Workspace,
                _ => null,
            };
        }
    }
}