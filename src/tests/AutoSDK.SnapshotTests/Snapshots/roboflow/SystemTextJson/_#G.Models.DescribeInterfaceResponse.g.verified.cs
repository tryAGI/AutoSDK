//HintName: G.Models.DescribeInterfaceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeInterfaceResponse
    {
        /// <summary>
        /// Dictionary mapping Workflow inputs to their kinds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Inputs { get; set; }

        /// <summary>
        /// Dictionary mapping Workflow outputs to their kinds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Outputs { get; set; }

        /// <summary>
        /// Dictionary mapping name of the kind with Python typing hint for underlying serialised object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typing_hints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> TypingHints { get; set; }

        /// <summary>
        /// Dictionary mapping name of the kind with OpenAPI 3.0 definitions of underlying objects. If list is given, entity should be treated as union of types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kinds_schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object KindsSchemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeInterfaceResponse" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Dictionary mapping Workflow inputs to their kinds
        /// </param>
        /// <param name="outputs">
        /// Dictionary mapping Workflow outputs to their kinds
        /// </param>
        /// <param name="typingHints">
        /// Dictionary mapping name of the kind with Python typing hint for underlying serialised object
        /// </param>
        /// <param name="kindsSchemas">
        /// Dictionary mapping name of the kind with OpenAPI 3.0 definitions of underlying objects. If list is given, entity should be treated as union of types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeInterfaceResponse(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> inputs,
            object outputs,
            global::System.Collections.Generic.Dictionary<string, string> typingHints,
            object kindsSchemas)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.TypingHints = typingHints ?? throw new global::System.ArgumentNullException(nameof(typingHints));
            this.KindsSchemas = kindsSchemas ?? throw new global::System.ArgumentNullException(nameof(kindsSchemas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeInterfaceResponse" /> class.
        /// </summary>
        public DescribeInterfaceResponse()
        {
        }
    }
}