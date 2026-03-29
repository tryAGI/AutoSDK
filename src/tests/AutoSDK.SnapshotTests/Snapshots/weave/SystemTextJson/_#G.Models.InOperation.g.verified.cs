//HintName: G.Models.InOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Membership check.<br/>
    /// Returns true if the left operand is in the list provided as the second operand.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$in": [<br/>
    ///             {"$getField": "op_name"},<br/>
    ///             [{"$literal": "predict"}, {"$literal": "generate"}]<br/>
    ///         ]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class InOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_in { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InOperation" /> class.
        /// </summary>
        /// <param name="x_in"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InOperation(
            byte[] x_in)
        {
            this.x_in = x_in ?? throw new global::System.ArgumentNullException(nameof(x_in));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InOperation" /> class.
        /// </summary>
        public InOperation()
        {
        }
    }
}