//HintName: G.Models.DependencyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
    /// Example: runtime
    /// </summary>
    public enum DependencyScope
    {
        /// <summary>
        /// 
        /// </summary>
        Runtime,
        /// <summary>
        /// 
        /// </summary>
        Development,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependencyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyScope value)
        {
            return value switch
            {
                DependencyScope.Runtime => "runtime",
                DependencyScope.Development => "development",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyScope? ToEnum(string value)
        {
            return value switch
            {
                "runtime" => DependencyScope.Runtime,
                "development" => DependencyScope.Development,
                _ => null,
            };
        }
    }
}