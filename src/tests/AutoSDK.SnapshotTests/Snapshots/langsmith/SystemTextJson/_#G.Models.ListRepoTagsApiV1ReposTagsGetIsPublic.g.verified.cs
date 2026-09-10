//HintName: G.Models.ListRepoTagsApiV1ReposTagsGetIsPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetIsPublic
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
    public static class ListRepoTagsApiV1ReposTagsGetIsPublicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetIsPublic value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetIsPublic.False => "false",
                ListRepoTagsApiV1ReposTagsGetIsPublic.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetIsPublic? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListRepoTagsApiV1ReposTagsGetIsPublic.False,
                "true" => ListRepoTagsApiV1ReposTagsGetIsPublic.True,
                _ => null,
            };
        }
    }
}