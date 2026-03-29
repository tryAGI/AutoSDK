//HintName: G.Models.FunctionIdGlobalFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Global function name
    /// </summary>
    public sealed partial class FunctionIdGlobalFunction
    {
        /// <summary>
        /// The name of the global function. Currently, the global namespace includes the functions in autoevals
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_function", Required = global::Newtonsoft.Json.Required.Always)]
        public string GlobalFunction { get; set; } = default!;

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdGlobalFunction" /> class.
        /// </summary>
        /// <param name="globalFunction">
        /// The name of the global function. Currently, the global namespace includes the functions in autoevals
        /// </param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        public FunctionIdGlobalFunction(
            string globalFunction,
            global::G.FunctionTypeEnum? functionType)
        {
            this.GlobalFunction = globalFunction ?? throw new global::System.ArgumentNullException(nameof(globalFunction));
            this.FunctionType = functionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdGlobalFunction" /> class.
        /// </summary>
        public FunctionIdGlobalFunction()
        {
        }
    }
}