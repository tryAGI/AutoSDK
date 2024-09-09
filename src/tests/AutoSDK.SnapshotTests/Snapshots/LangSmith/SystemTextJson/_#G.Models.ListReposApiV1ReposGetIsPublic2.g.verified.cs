//HintName: G.Models.ListReposApiV1ReposGetIsPublic2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetIsPublic2
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetIsPublic2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetIsPublic2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetIsPublic2.True => "true",
                ListReposApiV1ReposGetIsPublic2.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetIsPublic2? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListReposApiV1ReposGetIsPublic2.True,
                "false" => ListReposApiV1ReposGetIsPublic2.False,
                _ => null,
            };
        }
    }
}