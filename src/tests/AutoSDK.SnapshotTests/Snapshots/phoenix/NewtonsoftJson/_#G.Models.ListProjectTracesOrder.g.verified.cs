//HintName: G.Models.ListProjectTracesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort direction<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListProjectTracesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectTracesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectTracesOrder value)
        {
            return value switch
            {
                ListProjectTracesOrder.Asc => "asc",
                ListProjectTracesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectTracesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectTracesOrder.Asc,
                "desc" => ListProjectTracesOrder.Desc,
                _ => null,
            };
        }
    }
}