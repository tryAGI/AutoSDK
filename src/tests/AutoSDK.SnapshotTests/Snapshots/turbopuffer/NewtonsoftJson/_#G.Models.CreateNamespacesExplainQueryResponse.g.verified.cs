//HintName: G.Models.CreateNamespacesExplainQueryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a successful query explain.
    /// </summary>
    public sealed partial class CreateNamespacesExplainQueryResponse
    {
        /// <summary>
        /// The textual representation of the query plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_text")]
        public string? PlanText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesExplainQueryResponse" /> class.
        /// </summary>
        /// <param name="planText">
        /// The textual representation of the query plan.
        /// </param>
        public CreateNamespacesExplainQueryResponse(
            string? planText)
        {
            this.PlanText = planText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesExplainQueryResponse" /> class.
        /// </summary>
        public CreateNamespacesExplainQueryResponse()
        {
        }
    }
}