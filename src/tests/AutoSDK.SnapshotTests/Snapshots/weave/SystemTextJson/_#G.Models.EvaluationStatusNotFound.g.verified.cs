//HintName: G.Models.EvaluationStatusNotFound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusNotFound
    {
        /// <summary>
        /// Default Value: not_found
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusNotFound" /> class.
        /// </summary>
        /// <param name="code">
        /// Default Value: not_found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationStatusNotFound(
            string? code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusNotFound" /> class.
        /// </summary>
        public EvaluationStatusNotFound()
        {
        }
    }
}