//HintName: G.Models.FilterBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNode Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterBranchOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterBranchOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNode Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterBranch" /> class.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="operator"></param>
        /// <param name="right"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterBranch(
            global::G.FilterNode left,
            global::G.FilterBranchOperator @operator,
            global::G.FilterNode right)
        {
            this.Left = left;
            this.Operator = @operator;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterBranch" /> class.
        /// </summary>
        public FilterBranch()
        {
        }
    }
}