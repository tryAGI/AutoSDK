//HintName: G.Models.ListReposApiV1ReposGetSortDirectionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListReposApiV1ReposGetSortDirectionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetSortDirectionVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSortDirectionVariant2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSortDirectionVariant2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSortDirectionVariant2? ToEnum(string value)
        {
            return value switch
            {
                "desc" => ListReposApiV1ReposGetSortDirectionVariant2.Desc,
                _ => null,
            };
        }
    }
}