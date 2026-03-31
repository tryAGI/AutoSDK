//HintName: G.Models.FunctionDataNullishRemoteEval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A remote eval to run
    /// </summary>
    public sealed partial class FunctionDataNullishRemoteEval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter))]
        public global::G.FunctionDataNullishRemoteEvalType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Parameters { get; set; }

        /// <summary>
        /// The version (transaction ID) of the parameters being used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters_version")]
        public string? ParametersVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishRemoteEval" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="evalName"></param>
        /// <param name="parameters"></param>
        /// <param name="type"></param>
        /// <param name="parametersVersion">
        /// The version (transaction ID) of the parameters being used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishRemoteEval(
            string endpoint,
            string evalName,
            global::System.Collections.Generic.Dictionary<string, object?> parameters,
            global::G.FunctionDataNullishRemoteEvalType type,
            string? parametersVersion)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.EvalName = evalName ?? throw new global::System.ArgumentNullException(nameof(evalName));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.ParametersVersion = parametersVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishRemoteEval" /> class.
        /// </summary>
        public FunctionDataNullishRemoteEval()
        {
        }
    }
}