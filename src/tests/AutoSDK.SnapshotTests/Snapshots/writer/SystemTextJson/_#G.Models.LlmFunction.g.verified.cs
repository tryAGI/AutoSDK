//HintName: G.Models.LlmFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses another Writer model to generate a response.
    /// </summary>
    public sealed partial class LlmFunction
    {
        /// <summary>
        /// A description of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmFunction" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of the model to use.
        /// </param>
        /// <param name="model">
        /// The model to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmFunction(
            string description,
            string model)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmFunction" /> class.
        /// </summary>
        public LlmFunction()
        {
        }
    }
}