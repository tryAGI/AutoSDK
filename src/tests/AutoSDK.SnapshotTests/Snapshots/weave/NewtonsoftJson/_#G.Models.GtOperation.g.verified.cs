//HintName: G.Models.GtOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Greater than comparison.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$gt": [{"$getField": "summary.usage.tokens"}, {"$literal": 100}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class GtOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("$gt", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] x_gt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GtOperation" /> class.
        /// </summary>
        /// <param name="x_gt"></param>
        public GtOperation(
            byte[] x_gt)
        {
            this.x_gt = x_gt ?? throw new global::System.ArgumentNullException(nameof(x_gt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GtOperation" /> class.
        /// </summary>
        public GtOperation()
        {
        }
    }
}