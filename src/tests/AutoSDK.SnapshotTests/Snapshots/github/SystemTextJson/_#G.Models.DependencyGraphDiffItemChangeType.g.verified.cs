//HintName: G.Models.DependencyGraphDiffItemChangeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependencyGraphDiffItemChangeType
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
    public static class DependencyGraphDiffItemChangeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffItemChangeType value)
        {
            return value switch
            {
                DependencyGraphDiffItemChangeType.Added => "added",
                DependencyGraphDiffItemChangeType.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffItemChangeType? ToEnum(string value)
        {
            return value switch
            {
                "added" => DependencyGraphDiffItemChangeType.Added,
                "removed" => DependencyGraphDiffItemChangeType.Removed,
                _ => null,
            };
        }
    }
}