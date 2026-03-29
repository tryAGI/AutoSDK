//HintName: G.Models.ListMessagesForStepOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMessagesForStepOrder
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
    public static class ListMessagesForStepOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessagesForStepOrder value)
        {
            return value switch
            {
                ListMessagesForStepOrder.Asc => "asc",
                ListMessagesForStepOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessagesForStepOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessagesForStepOrder.Asc,
                "desc" => ListMessagesForStepOrder.Desc,
                _ => null,
            };
        }
    }
}