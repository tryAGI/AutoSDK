//HintName: G.Models.DependencyGraphDiffChangeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependencyGraphDiffChangeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="added")]
        Added,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
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