//HintName: G.Models.EvalFilterBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalFilterBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalFilterNode Right { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalFilterBranchOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalFilterBranchOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalFilterNode Left { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalFilterBranch" /> class.
        /// </summary>
        /// <param name="right"></param>
        /// <param name="operator"></param>
        /// <param name="left"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalFilterBranch(
            global::G.EvalFilterNode right,
            global::G.EvalFilterBranchOperator @operator,
            global::G.EvalFilterNode left)
        {
            this.Right = right;
            this.Operator = @operator;
            this.Left = left;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalFilterBranch" /> class.
        /// </summary>
        public EvalFilterBranch()
        {
        }
    }
}