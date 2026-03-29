//HintName: G.Models.PutAdminWorkspacesRequestDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAdminWorkspacesRequestDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_guardrails")]
        public global::System.Collections.Generic.IList<string>? InputGuardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_guardrails")]
        public global::System.Collections.Generic.IList<string>? OutputGuardrails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesRequestDefaults" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="inputGuardrails"></param>
        /// <param name="outputGuardrails"></param>
        public PutAdminWorkspacesRequestDefaults(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<string>? inputGuardrails,
            global::System.Collections.Generic.IList<string>? outputGuardrails)
        {
            this.Metadata = metadata;
            this.InputGuardrails = inputGuardrails;
            this.OutputGuardrails = outputGuardrails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesRequestDefaults" /> class.
        /// </summary>
        public PutAdminWorkspacesRequestDefaults()
        {
        }
    }
}