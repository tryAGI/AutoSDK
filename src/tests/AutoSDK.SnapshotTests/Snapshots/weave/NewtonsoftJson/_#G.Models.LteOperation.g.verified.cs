//HintName: G.Models.LteOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Less than or equal comparison.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$lte": [{"$getField": "summary.usage.tokens"}, {"$literal": 100}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class LteOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("$lte", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] x_lte { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LteOperation" /> class.
        /// </summary>
        /// <param name="x_lte"></param>
        public LteOperation(
            byte[] x_lte)
        {
            this.x_lte = x_lte ?? throw new global::System.ArgumentNullException(nameof(x_lte));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LteOperation" /> class.
        /// </summary>
        public LteOperation()
        {
        }
    }
}