//HintName: G.Models.ProjectResponseModelFiction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the project is fiction.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelFiction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiction")]
        Fiction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non-fiction")]
        NonFiction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelFictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelFiction value)
        {
            return value switch
            {
                ProjectResponseModelFiction.Fiction => "fiction",
                ProjectResponseModelFiction.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelFiction? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => ProjectResponseModelFiction.Fiction,
                "non-fiction" => ProjectResponseModelFiction.NonFiction,
                _ => null,
            };
        }
    }
}