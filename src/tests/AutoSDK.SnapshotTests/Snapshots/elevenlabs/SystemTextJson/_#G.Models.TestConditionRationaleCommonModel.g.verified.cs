//HintName: G.Models.TestConditionRationaleCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured rationale for test condition results containing individual failure/success reasons.
    /// </summary>
    public sealed partial class TestConditionRationaleCommonModel
    {
        /// <summary>
        /// List of individual parameter evaluation messages or reasons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// High-level summary of the evaluation result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionRationaleCommonModel" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of individual parameter evaluation messages or reasons
        /// </param>
        /// <param name="summary">
        /// High-level summary of the evaluation result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestConditionRationaleCommonModel(
            global::System.Collections.Generic.IList<string>? messages,
            string? summary)
        {
            this.Messages = messages;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionRationaleCommonModel" /> class.
        /// </summary>
        public TestConditionRationaleCommonModel()
        {
        }
    }
}