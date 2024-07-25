//HintName: G.Models.AccessScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessScope
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
    public static class AccessScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessScope value)
        {
            return value switch
            {
                AccessScope.Organization => "organization",
                AccessScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AccessScope.Organization,
                "workspace" => AccessScope.Workspace,
                _ => null,
            };
        }
    }
}