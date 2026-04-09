//HintName: G.Models.DatasetFilterBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetFilterBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetFilterNode Right { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetFilterBranchOperatorJsonConverter))]
        public global::G.DatasetFilterBranchOperator Operator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetFilterNode Left { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFilterBranch" /> class.
        /// </summary>
        /// <param name="right"></param>
        /// <param name="operator"></param>
        /// <param name="left"></param>
        public DatasetFilterBranch(
            global::G.DatasetFilterNode right,
            global::G.DatasetFilterBranchOperator @operator,
            global::G.DatasetFilterNode left)
        {
            this.Right = right;
            this.Operator = @operator;
            this.Left = left;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFilterBranch" /> class.
        /// </summary>
        public DatasetFilterBranch()
        {
        }
    }
}