//HintName: G.Models.ListEvalsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListEvalsOrderBy
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
    public static class ListEvalsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEvalsOrderBy value)
        {
            return value switch
            {
                ListEvalsOrderBy.CreatedAt => "created_at",
                ListEvalsOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEvalsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListEvalsOrderBy.CreatedAt,
                "updated_at" => ListEvalsOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}