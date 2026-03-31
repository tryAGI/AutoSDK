//HintName: G.Models.ScopeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScopeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScopeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScopeMethod value)
        {
            return value switch
            {
                ScopeMethod.Create => "create",
                ScopeMethod.Delete => "delete",
                ScopeMethod.List => "list",
                ScopeMethod.Read => "read",
                ScopeMethod.Search => "search",
                ScopeMethod.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScopeMethod? ToEnum(string value)
        {
            return value switch
            {
                "create" => ScopeMethod.Create,
                "delete" => ScopeMethod.Delete,
                "list" => ScopeMethod.List,
                "read" => ScopeMethod.Read,
                "search" => ScopeMethod.Search,
                "write" => ScopeMethod.Write,
                _ => null,
            };
        }
    }
}