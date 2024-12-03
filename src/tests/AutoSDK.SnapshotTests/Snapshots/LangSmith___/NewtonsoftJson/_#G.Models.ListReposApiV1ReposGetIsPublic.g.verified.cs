//HintName: G.Models.ListReposApiV1ReposGetIsPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListReposApiV1ReposGetIsPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="true")]
        True,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false")]
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetIsPublicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetIsPublic value)
        {
            return value switch
            {
                ListReposApiV1ReposGetIsPublic.True => "true",
                ListReposApiV1ReposGetIsPublic.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetIsPublic? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListReposApiV1ReposGetIsPublic.True,
                "false" => ListReposApiV1ReposGetIsPublic.False,
                _ => null,
            };
        }
    }
}