//HintName: G.Models.LemurSummaryParamsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurSummaryParamsVariant2
    {
        /// <summary>
        /// How you want the summary to be returned. This can be any text. Examples: "TLDR", "bullet points"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_format")]
        public string? AnswerFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}