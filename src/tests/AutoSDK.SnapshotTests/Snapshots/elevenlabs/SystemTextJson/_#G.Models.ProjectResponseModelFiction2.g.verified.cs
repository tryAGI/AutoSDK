//HintName: G.Models.ProjectResponseModelFiction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectResponseModelFiction2
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
    public static class ProjectResponseModelFiction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelFiction2 value)
        {
            return value switch
            {
                ProjectResponseModelFiction2.Fiction => "fiction",
                ProjectResponseModelFiction2.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelFiction2? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => ProjectResponseModelFiction2.Fiction,
                "non-fiction" => ProjectResponseModelFiction2.NonFiction,
                _ => null,
            };
        }
    }
}