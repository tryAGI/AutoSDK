//HintName: G.Models.DependencyGraphDiffItemScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
    /// </summary>
    public enum DependencyGraphDiffItemScope
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
    public static class DependencyGraphDiffItemScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffItemScope value)
        {
            return value switch
            {
                DependencyGraphDiffItemScope.Unknown => "unknown",
                DependencyGraphDiffItemScope.Runtime => "runtime",
                DependencyGraphDiffItemScope.Development => "development",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffItemScope? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependencyGraphDiffItemScope.Unknown,
                "runtime" => DependencyGraphDiffItemScope.Runtime,
                "development" => DependencyGraphDiffItemScope.Development,
                _ => null,
            };
        }
    }
}