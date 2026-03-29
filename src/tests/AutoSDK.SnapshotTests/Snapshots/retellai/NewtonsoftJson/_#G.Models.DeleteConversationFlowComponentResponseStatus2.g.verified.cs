//HintName: G.Models.DeleteConversationFlowComponentResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteConversationFlowComponentResponseStatus2
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
    public static class DeleteConversationFlowComponentResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowComponentResponseStatus2 value)
        {
            return value switch
            {
                DeleteConversationFlowComponentResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowComponentResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowComponentResponseStatus2.Error,
                _ => null,
            };
        }
    }
}