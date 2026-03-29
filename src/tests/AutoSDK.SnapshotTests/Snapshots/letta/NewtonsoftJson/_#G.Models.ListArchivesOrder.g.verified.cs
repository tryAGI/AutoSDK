//HintName: G.Models.ListArchivesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for archives by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListArchivesOrder
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
    public static class ListArchivesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListArchivesOrder value)
        {
            return value switch
            {
                ListArchivesOrder.Asc => "asc",
                ListArchivesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListArchivesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListArchivesOrder.Asc,
                "desc" => ListArchivesOrder.Desc,
                _ => null,
            };
        }
    }
}