//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostFiction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional specification of whether the content of this Studio project is fiction.<br/>
    /// Example: fiction
    /// </summary>
    public enum BodyCreateStudioProjectV1StudioProjectsPostFiction
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostFictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostFiction value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostFiction.Fiction => "fiction",
                BodyCreateStudioProjectV1StudioProjectsPostFiction.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostFiction? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => BodyCreateStudioProjectV1StudioProjectsPostFiction.Fiction,
                "non-fiction" => BodyCreateStudioProjectV1StudioProjectsPostFiction.NonFiction,
                _ => null,
            };
        }
    }
}