//HintName: G.Models.ListTestCaseDefinitionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTestCaseDefinitionsType
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
    public static class ListTestCaseDefinitionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestCaseDefinitionsType value)
        {
            return value switch
            {
                ListTestCaseDefinitionsType.ConversationFlow => "conversation-flow",
                ListTestCaseDefinitionsType.RetellLlm => "retell-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestCaseDefinitionsType? ToEnum(string value)
        {
            return value switch
            {
                "conversation-flow" => ListTestCaseDefinitionsType.ConversationFlow,
                "retell-llm" => ListTestCaseDefinitionsType.RetellLlm,
                _ => null,
            };
        }
    }
}