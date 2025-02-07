//HintName: G.Models.DataSpecification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DataSpecification describes the JSON schema of component input and output.
    /// </summary>
    public sealed partial class DataSpecification
    {
        /// <summary>
        /// JSON schema describing the component input data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// JSON schema describing the component output data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSpecification" /> class.
        /// </summary>
        /// <param name="input">
        /// JSON schema describing the component input data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="output">
        /// JSON schema describing the component output data.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSpecification(
            object? input,
            object? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSpecification" /> class.
        /// </summary>
        public DataSpecification()
        {
        }
    }
}