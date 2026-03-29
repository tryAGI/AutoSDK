//HintName: G.Models.ListBatchTestsV2Response2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBatchTestsV2Response2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.TestCaseBatchJob>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchTestsV2Response2" /> class.
        /// </summary>
        /// <param name="items"></param>
        public ListBatchTestsV2Response2(
            global::System.Collections.Generic.IList<global::G.TestCaseBatchJob>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchTestsV2Response2" /> class.
        /// </summary>
        public ListBatchTestsV2Response2()
        {
        }
    }
}