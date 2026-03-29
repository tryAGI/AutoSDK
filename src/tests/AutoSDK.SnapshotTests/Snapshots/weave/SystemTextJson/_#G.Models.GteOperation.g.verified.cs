//HintName: G.Models.GteOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Greater than or equal comparison.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$gte": [{"$getField": "summary.usage.tokens"}, {"$literal": 100}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class GteOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$gte")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_gte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GteOperation" /> class.
        /// </summary>
        /// <param name="x_gte"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GteOperation(
            byte[] x_gte)
        {
            this.x_gte = x_gte ?? throw new global::System.ArgumentNullException(nameof(x_gte));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GteOperation" /> class.
        /// </summary>
        public GteOperation()
        {
        }
    }
}