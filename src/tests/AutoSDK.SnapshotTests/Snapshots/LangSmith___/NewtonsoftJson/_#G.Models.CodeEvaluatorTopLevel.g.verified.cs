//HintName: G.Models.CodeEvaluatorTopLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeEvaluatorTopLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEvaluatorTopLevel" /> class.
        /// </summary>
        /// <param name="code"></param>
        public CodeEvaluatorTopLevel(
            string code)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEvaluatorTopLevel" /> class.
        /// </summary>
        public CodeEvaluatorTopLevel()
        {
        }
    }
}