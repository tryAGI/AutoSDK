//HintName: G.Models.ListReposApiV1ReposGetIsArchived2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetIsArchived2
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetIsArchived2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetIsArchived2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetIsArchived2.True => "true",
                ListReposApiV1ReposGetIsArchived2.Allow => "allow",
                ListReposApiV1ReposGetIsArchived2.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetIsArchived2? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListReposApiV1ReposGetIsArchived2.True,
                "allow" => ListReposApiV1ReposGetIsArchived2.Allow,
                "false" => ListReposApiV1ReposGetIsArchived2.False,
                _ => null,
            };
        }
    }
}