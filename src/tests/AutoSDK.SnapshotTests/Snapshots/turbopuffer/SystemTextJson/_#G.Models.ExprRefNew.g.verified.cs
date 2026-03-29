//HintName: G.Models.ExprRefNew.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference to an attribute in a new document.
    /// </summary>
    public sealed partial class ExprRefNew
    {
        /// <summary>
        /// The name of the attribute referenced in the new document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$ref_new")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_refNew { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExprRefNew" /> class.
        /// </summary>
        /// <param name="x_refNew">
        /// The name of the attribute referenced in the new document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExprRefNew(
            string x_refNew)
        {
            this.x_refNew = x_refNew ?? throw new global::System.ArgumentNullException(nameof(x_refNew));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExprRefNew" /> class.
        /// </summary>
        public ExprRefNew()
        {
        }
    }
}