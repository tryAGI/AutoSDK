//HintName: G.Models.ListBatchTestsV2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchTestsV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationFlow,
        /// <summary>
        /// 
        /// </summary>
        RetellLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchTestsV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchTestsV2Type value)
        {
            return value switch
            {
                ListBatchTestsV2Type.ConversationFlow => "conversation-flow",
                ListBatchTestsV2Type.RetellLlm => "retell-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchTestsV2Type? ToEnum(string value)
        {
            return value switch
            {
                "conversation-flow" => ListBatchTestsV2Type.ConversationFlow,
                "retell-llm" => ListBatchTestsV2Type.RetellLlm,
                _ => null,
            };
        }
    }
}