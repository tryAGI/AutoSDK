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
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// High-level summary of the evaluation result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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