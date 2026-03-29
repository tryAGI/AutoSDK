//HintName: G.Models.OpenAPIWorkflowInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIWorkflowInput
    {
        /// <summary>
        /// 输入参数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowInput" /> class.
        /// </summary>
        /// <param name="parameters">
        /// 输入参数
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIWorkflowInput(
            global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? parameters)
        {
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIWorkflowInput" /> class.
        /// </summary>
        public OpenAPIWorkflowInput()
        {
        }
    }
}