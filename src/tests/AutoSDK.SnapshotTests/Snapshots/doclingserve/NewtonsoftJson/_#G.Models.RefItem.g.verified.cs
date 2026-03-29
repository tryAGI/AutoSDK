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
        [global::Newtonsoft.Json.JsonProperty("$ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string x_ref { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefItem" /> class.
        /// </summary>
        /// <param name="x_ref"></param>
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