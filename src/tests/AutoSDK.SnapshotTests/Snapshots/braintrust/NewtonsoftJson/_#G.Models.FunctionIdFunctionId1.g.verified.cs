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
        [global::Newtonsoft.Json.JsonProperty("function_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionId { get; set; } = default!;

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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