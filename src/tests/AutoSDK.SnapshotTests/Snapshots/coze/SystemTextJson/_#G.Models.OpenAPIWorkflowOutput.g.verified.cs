//HintName: G.Models.OpenAPIWorkflowOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIWorkflowOutput
    {
        /// <summary>
        /// 返回文本时的输出内容，如{{output}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 输出参数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminate_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAPIEndReturnTypeJsonConverter))]
        public global::G.OpenAPIEndReturnType? TerminatePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowOutput" /> class.
        /// </summary>
        /// <param name="content">
        /// 返回文本时的输出内容，如{{output}}
        /// </param>
        /// <param name="parameters">
        /// 输出参数
        /// </param>
        /// <param name="terminatePlan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIWorkflowOutput(
            string? content,
            global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? parameters,
            global::G.OpenAPIEndReturnType? terminatePlan)
        {
            this.Content = content;
            this.Parameters = parameters;
            this.TerminatePlan = terminatePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowOutput" /> class.
        /// </summary>
        public OpenAPIWorkflowOutput()
        {
        }
    }
}