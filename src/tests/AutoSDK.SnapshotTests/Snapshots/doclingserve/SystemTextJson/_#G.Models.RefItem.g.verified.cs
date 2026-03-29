//HintName: G.Models.RefItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RefItem.
    /// </summary>
    public sealed partial class RefItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefItem" /> class.
        /// </summary>
        /// <param name="x_ref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefItem(
            string x_ref)
        {
            this.x_ref = x_ref ?? throw new global::System.ArgumentNullException(nameof(x_ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefItem" /> class.
        /// </summary>
        public RefItem()
        {
        }
    }
}