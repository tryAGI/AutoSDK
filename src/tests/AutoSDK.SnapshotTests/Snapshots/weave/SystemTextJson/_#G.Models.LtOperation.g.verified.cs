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
        [global::System.Text.Json.Serialization.JsonPropertyName("$lt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_lt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LtOperation" /> class.
        /// </summary>
        /// <param name="x_lt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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