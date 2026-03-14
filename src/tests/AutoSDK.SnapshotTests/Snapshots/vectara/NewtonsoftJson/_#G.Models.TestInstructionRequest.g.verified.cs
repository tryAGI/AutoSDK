//HintName: G.Models.TestInstructionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to test an instruction with provided context data.
    /// </summary>
    public sealed partial class TestInstructionRequest
    {
        /// <summary>
        /// Context data to use when rendering the instruction template. This will be merged into `$session.metadata` for template access.<br/>
        /// Example: If you provide `{"currentDate": "2024-01-15"}`, you can access it in the template as `$session.metadata.currentDate`.<br/>
        /// Example: {"currentDate":"2024-01-15","companyName":"Acme Corp"}
        /// </summary>
        /// <example>{"currentDate":"2024-01-15","companyName":"Acme Corp"}</example>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public object? Context { get; set; }

        /// <summary>
        /// List of tools to include in the instruction context for testing.<br/>
        /// Default Value: []<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInstructionRequest" /> class.
        /// </summary>
        /// <param name="context">
        /// Context data to use when rendering the instruction template. This will be merged into `$session.metadata` for template access.<br/>
        /// Example: If you provide `{"currentDate": "2024-01-15"}`, you can access it in the template as `$session.metadata.currentDate`.<br/>
        /// Example: {"currentDate":"2024-01-15","companyName":"Acme Corp"}
        /// </param>
        /// <param name="tools">
        /// List of tools to include in the instruction context for testing.<br/>
        /// Default Value: []<br/>
        /// Example: []
        /// </param>
        public TestInstructionRequest(
            object? context,
            global::System.Collections.Generic.IList<global::G.Tool>? tools)
        {
            this.Context = context;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInstructionRequest" /> class.
        /// </summary>
        public TestInstructionRequest()
        {
        }
    }
}