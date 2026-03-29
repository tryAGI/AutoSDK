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
        [global::System.Text.Json.Serialization.JsonPropertyName("$gt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_gt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GtOperation" /> class.
        /// </summary>
        /// <param name="x_gt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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