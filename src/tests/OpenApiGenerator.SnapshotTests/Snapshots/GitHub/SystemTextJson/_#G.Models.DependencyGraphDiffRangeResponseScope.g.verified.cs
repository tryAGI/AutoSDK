//HintName: G.Models.DependencyGraphDiffRangeResponseScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
    /// </summary>
    public enum DependencyGraphDiffRangeResponseScope
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
    public static class DependencyGraphDiffRangeResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffRangeResponseScope value)
        {
            return value switch
            {
                DependencyGraphDiffRangeResponseScope.Unknown => "unknown",
                DependencyGraphDiffRangeResponseScope.Runtime => "runtime",
                DependencyGraphDiffRangeResponseScope.Development => "development",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffRangeResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependencyGraphDiffRangeResponseScope.Unknown,
                "runtime" => DependencyGraphDiffRangeResponseScope.Runtime,
                "development" => DependencyGraphDiffRangeResponseScope.Development,
                _ => null,
            };
        }
    }
}