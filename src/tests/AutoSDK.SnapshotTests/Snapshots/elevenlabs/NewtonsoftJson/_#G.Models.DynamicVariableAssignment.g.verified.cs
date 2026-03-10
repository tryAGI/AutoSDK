//HintName: G.Models.DynamicVariableAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for extracting values from tool responses and assigning them to dynamic variables.<br/>
    /// Example: {"dynamic_variable":"user_name","sanitize":false,"source":"response","value_path":"user.name"}
    /// </summary>
    public sealed partial class DynamicVariableAssignment
    {
        /// <summary>
        /// The source to extract the value from. Currently only 'response' is supported.<br/>
        /// Default Value: response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The name of the dynamic variable to assign the extracted value to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variable", Required = global::Newtonsoft.Json.Required.Always)]
        public string DynamicVariable { get; set; } = default!;

        /// <summary>
        /// Dot notation path to extract the value from the source (e.g., 'user.name' or 'data.0.id')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string ValuePath { get; set; } = default!;

        /// <summary>
        /// If true, this assignment's value will be removed from the tool response before sending to the LLM and transcript, but still processed for variable assignment.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sanitize")]
        public bool? Sanitize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableAssignment" /> class.
        /// </summary>
        /// <param name="source">
        /// The source to extract the value from. Currently only 'response' is supported.<br/>
        /// Default Value: response
        /// </param>
        /// <param name="dynamicVariable">
        /// The name of the dynamic variable to assign the extracted value to
        /// </param>
        /// <param name="valuePath">
        /// Dot notation path to extract the value from the source (e.g., 'user.name' or 'data.0.id')
        /// </param>
        /// <param name="sanitize">
        /// If true, this assignment's value will be removed from the tool response before sending to the LLM and transcript, but still processed for variable assignment.<br/>
        /// Default Value: false
        /// </param>
        public DynamicVariableAssignment(
            string dynamicVariable,
            string valuePath,
            string? source,
            bool? sanitize)
        {
            this.DynamicVariable = dynamicVariable ?? throw new global::System.ArgumentNullException(nameof(dynamicVariable));
            this.ValuePath = valuePath ?? throw new global::System.ArgumentNullException(nameof(valuePath));
            this.Source = source;
            this.Sanitize = sanitize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableAssignment" /> class.
        /// </summary>
        public DynamicVariableAssignment()
        {
        }
    }
}