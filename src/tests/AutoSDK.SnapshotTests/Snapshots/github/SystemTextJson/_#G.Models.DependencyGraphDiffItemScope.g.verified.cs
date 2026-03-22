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
        Development,
        /// <summary>
        /// 
        /// </summary>
        Runtime,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
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
                DependencyGraphDiffItemScope.Development => "development",
                DependencyGraphDiffItemScope.Runtime => "runtime",
                DependencyGraphDiffItemScope.Unknown => "unknown",
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
                "development" => DependencyGraphDiffItemScope.Development,
                "runtime" => DependencyGraphDiffItemScope.Runtime,
                "unknown" => DependencyGraphDiffItemScope.Unknown,
                _ => null,
            };
        }
    }
}