//HintName: G.Models.LtOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Less than comparison.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$lt": [{"$getField": "summary.usage.tokens"}, {"$literal": 100}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class LtOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("$lt", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] x_lt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LtOperation" /> class.
        /// </summary>
        /// <param name="x_lt"></param>
        public LtOperation(
            byte[] x_lt)
        {
            this.x_lt = x_lt ?? throw new global::System.ArgumentNullException(nameof(x_lt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LtOperation" /> class.
        /// </summary>
        public LtOperation()
        {
        }
    }
}