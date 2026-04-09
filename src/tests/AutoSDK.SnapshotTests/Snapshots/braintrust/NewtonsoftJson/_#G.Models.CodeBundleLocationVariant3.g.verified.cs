//HintName: G.Models.CodeBundleLocationVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter))]
        public global::G.CodeBundleLocationVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandbox_spec", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CodeBundleLocationVariant3SandboxSpecVariant1, global::G.CodeBundleLocationVariant3SandboxSpecVariant2> SandboxSpec { get; set; } = default!;

        /// <summary>
        /// Which entrypoints to execute in the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entrypoints")]
        public global::System.Collections.Generic.IList<string>? Entrypoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalName { get; set; } = default!;

        /// <summary>
        /// Parameter values for sandbox eval execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Parameters { get; set; }

        /// <summary>
        /// Definition of current evaluator with parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluator_definition")]
        public object? EvaluatorDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3" /> class.
        /// </summary>
        /// <param name="sandboxSpec"></param>
        /// <param name="evalName"></param>
        /// <param name="type"></param>
        /// <param name="entrypoints">
        /// Which entrypoints to execute in the sandbox
        /// </param>
        /// <param name="parameters">
        /// Parameter values for sandbox eval execution
        /// </param>
        /// <param name="evaluatorDefinition">
        /// Definition of current evaluator with parameters
        /// </param>
        public CodeBundleLocationVariant3(
            global::G.OneOf<global::G.CodeBundleLocationVariant3SandboxSpecVariant1, global::G.CodeBundleLocationVariant3SandboxSpecVariant2> sandboxSpec,
            string evalName,
            global::G.CodeBundleLocationVariant3Type type,
            global::System.Collections.Generic.IList<string>? entrypoints,
            global::System.Collections.Generic.Dictionary<string, object?>? parameters,
            object? evaluatorDefinition)
        {
            this.Type = type;
            this.SandboxSpec = sandboxSpec;
            this.Entrypoints = entrypoints;
            this.EvalName = evalName ?? throw new global::System.ArgumentNullException(nameof(evalName));
            this.Parameters = parameters;
            this.EvaluatorDefinition = evaluatorDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3" /> class.
        /// </summary>
        public CodeBundleLocationVariant3()
        {
        }
    }
}