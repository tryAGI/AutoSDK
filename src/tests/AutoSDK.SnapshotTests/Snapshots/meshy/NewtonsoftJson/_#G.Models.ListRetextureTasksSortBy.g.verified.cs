//HintName: G.Models.ListRetextureTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRetextureTasksSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+created_at")]
        PluscreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-created_at")]
        MinuscreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRetextureTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetextureTasksSortBy value)
        {
            return value switch
            {
                ListRetextureTasksSortBy.PluscreatedAt => "+created_at",
                ListRetextureTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetextureTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListRetextureTasksSortBy.PluscreatedAt,
                "-created_at" => ListRetextureTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}