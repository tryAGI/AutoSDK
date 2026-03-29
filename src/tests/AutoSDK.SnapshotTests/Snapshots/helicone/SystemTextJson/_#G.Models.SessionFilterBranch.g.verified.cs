//HintName: G.Models.SessionFilterBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionFilterBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionFilterNode Right { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionFilterBranchOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionFilterBranchOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionFilterNode Left { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFilterBranch" /> class.
        /// </summary>
        /// <param name="right"></param>
        /// <param name="operator"></param>
        /// <param name="left"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionFilterBranch(
            global::G.SessionFilterNode right,
            global::G.SessionFilterBranchOperator @operator,
            global::G.SessionFilterNode left)
        {
            this.Right = right;
            this.Operator = @operator;
            this.Left = left;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFilterBranch" /> class.
        /// </summary>
        public SessionFilterBranch()
        {
        }
    }
}