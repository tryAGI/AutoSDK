//HintName: G.Models.FunctionCallingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for specifying function calling behavior.
    /// </summary>
    public sealed partial class FunctionCallingConfig
    {
        /// <summary>
        /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.FunctionCallingConfigMode? Mode { get; set; }

        /// <summary>
        /// Optional. A set of function names that, when provided, limits the functions the model will call. This should only be set when the Mode is ANY or VALIDATED. Function names should match [FunctionDeclaration.name]. When set, model will predict a function call from only allowed function names.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowedFunctionNames")]
        public global::System.Collections.Generic.IList<string>? AllowedFunctionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallingConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
        /// </param>
        /// <param name="allowedFunctionNames">
        /// Optional. A set of function names that, when provided, limits the functions the model will call. This should only be set when the Mode is ANY or VALIDATED. Function names should match [FunctionDeclaration.name]. When set, model will predict a function call from only allowed function names.
        /// </param>
        public FunctionCallingConfig(
            global::G.FunctionCallingConfigMode? mode,
            global::System.Collections.Generic.IList<string>? allowedFunctionNames)
        {
            this.Mode = mode;
            this.AllowedFunctionNames = allowedFunctionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallingConfig" /> class.
        /// </summary>
        public FunctionCallingConfig()
        {
        }
    }
}