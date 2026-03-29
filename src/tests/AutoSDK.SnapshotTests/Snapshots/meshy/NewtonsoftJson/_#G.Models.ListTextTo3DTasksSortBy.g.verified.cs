//HintName: G.Models.ListTextTo3DTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTextTo3DTasksSortBy
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
    public static class ListTextTo3DTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTextTo3DTasksSortBy value)
        {
            return value switch
            {
                ListTextTo3DTasksSortBy.PluscreatedAt => "+created_at",
                ListTextTo3DTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTextTo3DTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListTextTo3DTasksSortBy.PluscreatedAt,
                "-created_at" => ListTextTo3DTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}