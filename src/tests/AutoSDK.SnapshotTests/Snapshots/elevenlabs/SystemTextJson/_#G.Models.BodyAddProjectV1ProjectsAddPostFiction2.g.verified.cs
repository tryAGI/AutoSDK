//HintName: G.Models.BodyAddProjectV1ProjectsAddPostFiction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyAddProjectV1ProjectsAddPostFiction2
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
    public static class BodyAddProjectV1ProjectsAddPostFiction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostFiction2 value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostFiction2.Fiction => "fiction",
                BodyAddProjectV1ProjectsAddPostFiction2.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostFiction2? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => BodyAddProjectV1ProjectsAddPostFiction2.Fiction,
                "non-fiction" => BodyAddProjectV1ProjectsAddPostFiction2.NonFiction,
                _ => null,
            };
        }
    }
}