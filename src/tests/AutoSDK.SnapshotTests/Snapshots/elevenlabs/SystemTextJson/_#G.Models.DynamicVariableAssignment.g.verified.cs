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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The name of the dynamic variable to assign the extracted value to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DynamicVariable { get; set; }

        /// <summary>
        /// Dot notation path to extract the value from the source (e.g., 'user.name' or 'data.0.id')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValuePath { get; set; }

        /// <summary>
        /// If true, this assignment's value will be removed from the tool response before sending to the LLM and transcript, but still processed for variable assignment.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sanitize")]
        public bool? Sanitize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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