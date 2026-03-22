//HintName: G.Models.ListRepoTagsApiV1ReposTagsGetIsArchived2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetIsArchived2
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
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
    public static class ListRepoTagsApiV1ReposTagsGetIsArchived2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetIsArchived2 value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetIsArchived2.Allow => "allow",
                ListRepoTagsApiV1ReposTagsGetIsArchived2.False => "false",
                ListRepoTagsApiV1ReposTagsGetIsArchived2.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetIsArchived2? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ListRepoTagsApiV1ReposTagsGetIsArchived2.Allow,
                "false" => ListRepoTagsApiV1ReposTagsGetIsArchived2.False,
                "true" => ListRepoTagsApiV1ReposTagsGetIsArchived2.True,
                _ => null,
            };
        }
    }
}