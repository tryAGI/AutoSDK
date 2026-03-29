//HintName: G.Models.FunctionFunctionSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON schema for the function's parameters and return type
    /// </summary>
    public sealed partial class FunctionFunctionSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("returns")]
        public object? Returns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionFunctionSchema" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="returns"></param>
        public FunctionFunctionSchema(
            object? parameters,
            object? returns)
        {
            this.Parameters = parameters;
            this.Returns = returns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionFunctionSchema" /> class.
        /// </summary>
        public FunctionFunctionSchema()
        {
        }
    }
}