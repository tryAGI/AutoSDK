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
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Inputs { get; set; } = default!;

        /// <summary>
        /// Dictionary mapping Workflow outputs to their kinds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Outputs { get; set; } = default!;

        /// <summary>
        /// Dictionary mapping name of the kind with Python typing hint for underlying serialised object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("typing_hints", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> TypingHints { get; set; } = default!;

        /// <summary>
        /// Dictionary mapping name of the kind with OpenAPI 3.0 definitions of underlying objects. If list is given, entity should be treated as union of types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kinds_schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public object KindsSchemas { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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