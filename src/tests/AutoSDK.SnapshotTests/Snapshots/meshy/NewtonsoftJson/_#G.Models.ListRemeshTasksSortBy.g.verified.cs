//HintName: G.Models.ListRemeshTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRemeshTasksSortBy
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
    public static class ListRemeshTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRemeshTasksSortBy value)
        {
            return value switch
            {
                ListRemeshTasksSortBy.PluscreatedAt => "+created_at",
                ListRemeshTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRemeshTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListRemeshTasksSortBy.PluscreatedAt,
                "-created_at" => ListRemeshTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}