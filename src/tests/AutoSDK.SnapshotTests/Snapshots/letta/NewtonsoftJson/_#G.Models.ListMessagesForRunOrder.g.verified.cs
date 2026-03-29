//HintName: G.Models.ListMessagesForRunOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMessagesForRunOrder
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
    public static class ListMessagesForRunOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessagesForRunOrder value)
        {
            return value switch
            {
                ListMessagesForRunOrder.Asc => "asc",
                ListMessagesForRunOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessagesForRunOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessagesForRunOrder.Asc,
                "desc" => ListMessagesForRunOrder.Desc,
                _ => null,
            };
        }
    }
}