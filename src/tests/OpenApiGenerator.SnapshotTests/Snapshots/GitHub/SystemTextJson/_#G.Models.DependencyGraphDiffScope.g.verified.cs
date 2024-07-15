//HintName: G.Models.DependencyGraphDiffScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
    /// </summary>
    public enum DependencyGraphDiffScope
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
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
    public static class DependencyGraphDiffScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffScope value)
        {
            return value switch
            {
                DependencyGraphDiffScope.Unknown => "unknown",
                DependencyGraphDiffScope.Runtime => "runtime",
                DependencyGraphDiffScope.Development => "development",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffScope? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependencyGraphDiffScope.Unknown,
                "runtime" => DependencyGraphDiffScope.Runtime,
                "development" => DependencyGraphDiffScope.Development,
                _ => null,
            };
        }
    }
}