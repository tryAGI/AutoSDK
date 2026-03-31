//HintName: G.Models.CreateFunctionFunctionSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON schema for the function's parameters and return type
    /// </summary>
    public sealed partial class CreateFunctionFunctionSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returns")]
        public object? Returns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionFunctionSchema" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="returns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFunctionFunctionSchema(
            object? parameters,
            object? returns)
        {
            this.Parameters = parameters;
            this.Returns = returns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionFunctionSchema" /> class.
        /// </summary>
        public CreateFunctionFunctionSchema()
        {
        }
    }
}