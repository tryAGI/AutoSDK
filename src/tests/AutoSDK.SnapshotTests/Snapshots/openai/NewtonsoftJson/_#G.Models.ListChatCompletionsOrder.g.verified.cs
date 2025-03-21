//HintName: G.Models.ListChatCompletionsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListChatCompletionsOrder
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
    public static class ListChatCompletionsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatCompletionsOrder value)
        {
            return value switch
            {
                ListChatCompletionsOrder.Asc => "asc",
                ListChatCompletionsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatCompletionsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListChatCompletionsOrder.Asc,
                "desc" => ListChatCompletionsOrder.Desc,
                _ => null,
            };
        }
    }
}