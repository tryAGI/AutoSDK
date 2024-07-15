//HintName: G.Models.DependencyGraphDiffChangeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependencyGraphDiffChangeType
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependencyGraphDiffChangeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffChangeType value)
        {
            return value switch
            {
                DependencyGraphDiffChangeType.Added => "added",
                DependencyGraphDiffChangeType.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffChangeType? ToEnum(string value)
        {
            return value switch
            {
                "added" => DependencyGraphDiffChangeType.Added,
                "removed" => DependencyGraphDiffChangeType.Removed,
                _ => null,
            };
        }
    }
}