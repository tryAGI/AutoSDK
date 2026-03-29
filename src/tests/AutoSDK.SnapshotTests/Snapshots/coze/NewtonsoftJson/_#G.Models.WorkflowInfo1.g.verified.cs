//HintName: G.Models.WorkflowInfo1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowInfo1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.OpenAPIWorkflowInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.OpenAPIWorkflowOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_detail")]
        public global::G.OpenAPIWorkflowBasic? WorkflowDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo1" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="workflowDetail"></param>
        public WorkflowInfo1(
            global::G.OpenAPIWorkflowInput? input,
            global::G.OpenAPIWorkflowOutput? output,
            global::G.OpenAPIWorkflowBasic? workflowDetail)
        {
            this.Input = input;
            this.Output = output;
            this.WorkflowDetail = workflowDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo1" /> class.
        /// </summary>
        public WorkflowInfo1()
        {
        }
    }
}