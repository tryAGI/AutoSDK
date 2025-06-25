//HintName: G.Models.BodyAddProjectV1ProjectsAddPostFiction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional specification of whether the content of this Studio project is fiction.<br/>
    /// Example: fiction
    /// </summary>
    public enum BodyAddProjectV1ProjectsAddPostFiction
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
    public static class BodyAddProjectV1ProjectsAddPostFictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostFiction value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostFiction.Fiction => "fiction",
                BodyAddProjectV1ProjectsAddPostFiction.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostFiction? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => BodyAddProjectV1ProjectsAddPostFiction.Fiction,
                "non-fiction" => BodyAddProjectV1ProjectsAddPostFiction.NonFiction,
                _ => null,
            };
        }
    }
}