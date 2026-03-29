//HintName: G.Models.ListConversationFlowComponentsV2SortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationFlowComponentsV2SortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ascending")]
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="descending")]
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowComponentsV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsV2SortOrder value)
        {
            return value switch
            {
                ListConversationFlowComponentsV2SortOrder.Ascending => "ascending",
                ListConversationFlowComponentsV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListConversationFlowComponentsV2SortOrder.Ascending,
                "descending" => ListConversationFlowComponentsV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}