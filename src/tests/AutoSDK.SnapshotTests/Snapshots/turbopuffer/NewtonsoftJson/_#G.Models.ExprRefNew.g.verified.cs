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
        [global::Newtonsoft.Json.JsonProperty("$ref_new", Required = global::Newtonsoft.Json.Required.Always)]
        public string x_refNew { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExprRefNew" /> class.
        /// </summary>
        /// <param name="x_refNew">
        /// The name of the attribute referenced in the new document.
        /// </param>
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