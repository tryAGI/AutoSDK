//HintName: G.Models.ListConversationFlowsResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationFlowsResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsResponseStatus4 value)
        {
            return value switch
            {
                ListConversationFlowsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}