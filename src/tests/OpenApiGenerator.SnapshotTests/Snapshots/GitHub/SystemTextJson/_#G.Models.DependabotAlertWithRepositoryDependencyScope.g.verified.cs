//HintName: G.Models.DependabotAlertWithRepositoryDependencyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The execution scope of the vulnerable dependency.
    /// </summary>
    public enum DependabotAlertWithRepositoryDependencyScope
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Runtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertWithRepositoryDependencyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertWithRepositoryDependencyScope value)
        {
            return value switch
            {
                DependabotAlertWithRepositoryDependencyScope.Development => "development",
                DependabotAlertWithRepositoryDependencyScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertWithRepositoryDependencyScope ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotAlertWithRepositoryDependencyScope.Development,
                "runtime" => DependabotAlertWithRepositoryDependencyScope.Runtime,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}