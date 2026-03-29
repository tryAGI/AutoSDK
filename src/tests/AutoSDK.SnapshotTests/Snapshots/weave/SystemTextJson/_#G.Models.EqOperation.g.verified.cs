//HintName: G.Models.EqOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Equality check between two operands.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$eq": [{"$getField": "op_name"}, {"$literal": "predict"}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class EqOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$eq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_eq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EqOperation" /> class.
        /// </summary>
        /// <param name="x_eq"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EqOperation(
            byte[] x_eq)
        {
            this.x_eq = x_eq ?? throw new global::System.ArgumentNullException(nameof(x_eq));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EqOperation" /> class.
        /// </summary>
        public EqOperation()
        {
        }
    }
}