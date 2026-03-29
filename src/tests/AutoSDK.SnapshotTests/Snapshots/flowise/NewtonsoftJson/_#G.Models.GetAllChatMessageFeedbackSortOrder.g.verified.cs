//HintName: G.Models.GetAllChatMessageFeedbackSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAllChatMessageFeedbackSortOrder
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
    public static class GetAllChatMessageFeedbackSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessageFeedbackSortOrder value)
        {
            return value switch
            {
                GetAllChatMessageFeedbackSortOrder.Asc => "asc",
                GetAllChatMessageFeedbackSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessageFeedbackSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAllChatMessageFeedbackSortOrder.Asc,
                "desc" => GetAllChatMessageFeedbackSortOrder.Desc,
                _ => null,
            };
        }
    }
}