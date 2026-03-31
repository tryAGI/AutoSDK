//HintName: G.Models.FunctionIdFunctionId1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Function id
    /// </summary>
    public sealed partial class FunctionIdFunctionId1
    {
        /// <summary>
        /// The ID of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionId { get; set; }

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdFunctionId1" /> class.
        /// </summary>
        /// <param name="functionId">
        /// The ID of the function
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionIdFunctionId1(
            string functionId,
            string? version)
        {
            this.FunctionId = functionId ?? throw new global::System.ArgumentNullException(nameof(functionId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdFunctionId1" /> class.
        /// </summary>
        public FunctionIdFunctionId1()
        {
        }
    }
}