//HintName: G.Models.FunctionDataRemoteEval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A remote eval to run
    /// </summary>
    public sealed partial class FunctionDataRemoteEval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter))]
        public global::G.FunctionDataRemoteEvalType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Parameters { get; set; } = default!;

        /// <summary>
        /// The version (transaction ID) of the parameters being used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters_version")]
        public string? ParametersVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataRemoteEval" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="evalName"></param>
        /// <param name="parameters"></param>
        /// <param name="type"></param>
        /// <param name="parametersVersion">
        /// The version (transaction ID) of the parameters being used
        /// </param>
        public FunctionDataRemoteEval(
            string endpoint,
            string evalName,
            global::System.Collections.Generic.Dictionary<string, object?> parameters,
            global::G.FunctionDataRemoteEvalType type,
            string? parametersVersion)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.EvalName = evalName ?? throw new global::System.ArgumentNullException(nameof(evalName));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.ParametersVersion = parametersVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataRemoteEval" /> class.
        /// </summary>
        public FunctionDataRemoteEval()
        {
        }
    }
}