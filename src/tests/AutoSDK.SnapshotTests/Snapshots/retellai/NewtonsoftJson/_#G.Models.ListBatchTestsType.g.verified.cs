//HintName: G.Models.ListBatchTestsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListBatchTestsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation-flow")]
        ConversationFlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retell-llm")]
        RetellLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchTestsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchTestsType value)
        {
            return value switch
            {
                ListBatchTestsType.ConversationFlow => "conversation-flow",
                ListBatchTestsType.RetellLlm => "retell-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchTestsType? ToEnum(string value)
        {
            return value switch
            {
                "conversation-flow" => ListBatchTestsType.ConversationFlow,
                "retell-llm" => ListBatchTestsType.RetellLlm,
                _ => null,
            };
        }
    }
}