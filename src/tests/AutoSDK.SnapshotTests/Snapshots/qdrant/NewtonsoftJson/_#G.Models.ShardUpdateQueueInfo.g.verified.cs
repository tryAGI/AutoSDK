//HintName: G.Models.ShardUpdateQueueInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardUpdateQueueInfo
    {
        /// <summary>
        /// Number of elements in the queue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public int Length { get; set; } = default!;

        /// <summary>
        /// last operation number processed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op_num")]
        public int? OpNum { get; set; }

        /// <summary>
        /// Number of points that are deferred (i.e hidden from search as they're not yet optimized).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deferred_points")]
        public int? DeferredPoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardUpdateQueueInfo" /> class.
        /// </summary>
        /// <param name="length">
        /// Number of elements in the queue
        /// </param>
        /// <param name="opNum">
        /// last operation number processed
        /// </param>
        /// <param name="deferredPoints">
        /// Number of points that are deferred (i.e hidden from search as they're not yet optimized).
        /// </param>
        public ShardUpdateQueueInfo(
            int length,
            int? opNum,
            int? deferredPoints)
        {
            this.Length = length;
            this.OpNum = opNum;
            this.DeferredPoints = deferredPoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardUpdateQueueInfo" /> class.
        /// </summary>
        public ShardUpdateQueueInfo()
        {
        }
    }
}