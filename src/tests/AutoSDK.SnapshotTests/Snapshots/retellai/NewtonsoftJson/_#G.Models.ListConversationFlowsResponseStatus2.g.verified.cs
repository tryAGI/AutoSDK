//HintName: G.Models.ListConversationFlowsResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationFlowsResponseStatus2
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
    public static class ListConversationFlowsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsResponseStatus2 value)
        {
            return value switch
            {
                ListConversationFlowsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}