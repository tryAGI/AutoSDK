//HintName: G.Models.DependencyGraphDiffRangeResponseChangeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependencyGraphDiffRangeResponseChangeType
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
    public static class DependencyGraphDiffRangeResponseChangeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyGraphDiffRangeResponseChangeType value)
        {
            return value switch
            {
                DependencyGraphDiffRangeResponseChangeType.Added => "added",
                DependencyGraphDiffRangeResponseChangeType.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyGraphDiffRangeResponseChangeType? ToEnum(string value)
        {
            return value switch
            {
                "added" => DependencyGraphDiffRangeResponseChangeType.Added,
                "removed" => DependencyGraphDiffRangeResponseChangeType.Removed,
                _ => null,
            };
        }
    }
}