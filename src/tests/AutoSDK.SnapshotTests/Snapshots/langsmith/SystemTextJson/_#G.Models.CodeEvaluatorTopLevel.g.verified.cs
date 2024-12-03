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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEvaluatorTopLevel" /> class.
        /// </summary>
        /// <param name="code"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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