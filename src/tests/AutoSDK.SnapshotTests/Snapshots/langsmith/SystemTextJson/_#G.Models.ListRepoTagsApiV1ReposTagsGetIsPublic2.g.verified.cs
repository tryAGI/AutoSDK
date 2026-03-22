//HintName: G.Models.ListRepoTagsApiV1ReposTagsGetIsPublic2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetIsPublic2
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRepoTagsApiV1ReposTagsGetIsPublic2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetIsPublic2 value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetIsPublic2.False => "false",
                ListRepoTagsApiV1ReposTagsGetIsPublic2.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetIsPublic2? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListRepoTagsApiV1ReposTagsGetIsPublic2.False,
                "true" => ListRepoTagsApiV1ReposTagsGetIsPublic2.True,
                _ => null,
            };
        }
    }
}