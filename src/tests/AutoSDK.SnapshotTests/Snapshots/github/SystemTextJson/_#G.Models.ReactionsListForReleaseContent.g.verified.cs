//HintName: G.Models.ReactionsListForReleaseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForReleaseContent
    {
        /// <summary>
        /// 
        /// </summary>
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsListForReleaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForReleaseContent value)
        {
            return value switch
            {
                ReactionsListForReleaseContent.Plus1 => "+1",
                ReactionsListForReleaseContent.Eyes => "eyes",
                ReactionsListForReleaseContent.Heart => "heart",
                ReactionsListForReleaseContent.Hooray => "hooray",
                ReactionsListForReleaseContent.Laugh => "laugh",
                ReactionsListForReleaseContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForReleaseContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForReleaseContent.Plus1,
                "eyes" => ReactionsListForReleaseContent.Eyes,
                "heart" => ReactionsListForReleaseContent.Heart,
                "hooray" => ReactionsListForReleaseContent.Hooray,
                "laugh" => ReactionsListForReleaseContent.Laugh,
                "rocket" => ReactionsListForReleaseContent.Rocket,
                _ => null,
            };
        }
    }
}