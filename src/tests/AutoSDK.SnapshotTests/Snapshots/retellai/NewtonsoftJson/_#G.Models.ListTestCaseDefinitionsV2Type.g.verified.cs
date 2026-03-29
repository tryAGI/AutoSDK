//HintName: G.Models.ListTestCaseDefinitionsV2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListTestCaseDefinitionsV2Type
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
    public static class ListTestCaseDefinitionsV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestCaseDefinitionsV2Type value)
        {
            return value switch
            {
                ListTestCaseDefinitionsV2Type.ConversationFlow => "conversation-flow",
                ListTestCaseDefinitionsV2Type.RetellLlm => "retell-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestCaseDefinitionsV2Type? ToEnum(string value)
        {
            return value switch
            {
                "conversation-flow" => ListTestCaseDefinitionsV2Type.ConversationFlow,
                "retell-llm" => ListTestCaseDefinitionsV2Type.RetellLlm,
                _ => null,
            };
        }
    }
}