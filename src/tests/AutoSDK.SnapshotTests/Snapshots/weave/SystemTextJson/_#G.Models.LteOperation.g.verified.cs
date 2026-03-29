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
        [global::System.Text.Json.Serialization.JsonPropertyName("$lte")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LteOperation" /> class.
        /// </summary>
        /// <param name="x_lte"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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