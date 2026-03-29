//HintName: G.Models.ProjectStatItemObjectPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectStatItemObjectPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AVG")]
        Avg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COUNT")]
        Count,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PERCENTAGE")]
        Percentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectStatItemObjectPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectStatItemObjectPublicType value)
        {
            return value switch
            {
                ProjectStatItemObjectPublicType.Avg => "AVG",
                ProjectStatItemObjectPublicType.Count => "COUNT",
                ProjectStatItemObjectPublicType.Percentage => "PERCENTAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectStatItemObjectPublicType? ToEnum(string value)
        {
            return value switch
            {
                "AVG" => ProjectStatItemObjectPublicType.Avg,
                "COUNT" => ProjectStatItemObjectPublicType.Count,
                "PERCENTAGE" => ProjectStatItemObjectPublicType.Percentage,
                _ => null,
            };
        }
    }
}