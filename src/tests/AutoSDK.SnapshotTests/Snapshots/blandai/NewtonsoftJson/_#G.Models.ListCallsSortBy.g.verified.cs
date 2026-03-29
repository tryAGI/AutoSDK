//HintName: G.Models.ListCallsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCallsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsSortBy value)
        {
            return value switch
            {
                ListCallsSortBy.CreatedAt => "created_at",
                ListCallsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListCallsSortBy.CreatedAt,
                "updated_at" => ListCallsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}