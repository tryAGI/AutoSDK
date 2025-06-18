//HintName: G.Models.EvalGraderPythonVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalGraderPythonVariant2
    {
        /// <summary>
        /// The threshold for the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        public double? PassThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalGraderPythonVariant2" /> class.
        /// </summary>
        /// <param name="passThreshold">
        /// The threshold for the score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalGraderPythonVariant2(
            double? passThreshold)
        {
            this.PassThreshold = passThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalGraderPythonVariant2" /> class.
        /// </summary>
        public EvalGraderPythonVariant2()
        {
        }
    }
}