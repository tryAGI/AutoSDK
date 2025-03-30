//HintName: G.Models.ProjectExtendedResponseModelFiction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the project is fiction.
    /// </summary>
    public enum ProjectExtendedResponseModelFiction
    {
        /// <summary>
        /// 
        /// </summary>
        Fiction,
        /// <summary>
        /// 
        /// </summary>
        NonFiction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelFictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelFiction value)
        {
            return value switch
            {
                ProjectExtendedResponseModelFiction.Fiction => "fiction",
                ProjectExtendedResponseModelFiction.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelFiction? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => ProjectExtendedResponseModelFiction.Fiction,
                "non-fiction" => ProjectExtendedResponseModelFiction.NonFiction,
                _ => null,
            };
        }
    }
}