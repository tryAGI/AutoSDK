//HintName: G.Models.ProjectStatItemObjectPublicDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectStatItemObjectPublicDiscriminatorType
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
    public static class ProjectStatItemObjectPublicDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectStatItemObjectPublicDiscriminatorType value)
        {
            return value switch
            {
                ProjectStatItemObjectPublicDiscriminatorType.Avg => "AVG",
                ProjectStatItemObjectPublicDiscriminatorType.Count => "COUNT",
                ProjectStatItemObjectPublicDiscriminatorType.Percentage => "PERCENTAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectStatItemObjectPublicDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AVG" => ProjectStatItemObjectPublicDiscriminatorType.Avg,
                "COUNT" => ProjectStatItemObjectPublicDiscriminatorType.Count,
                "PERCENTAGE" => ProjectStatItemObjectPublicDiscriminatorType.Percentage,
                _ => null,
            };
        }
    }
}