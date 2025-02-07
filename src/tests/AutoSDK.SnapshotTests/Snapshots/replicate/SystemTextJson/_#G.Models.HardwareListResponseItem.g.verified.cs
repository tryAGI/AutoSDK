//HintName: G.Models.HardwareListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HardwareListResponseItem
    {
        /// <summary>
        /// The name of the hardware.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The SKU of the hardware.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        public string? Sku { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareListResponseItem" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the hardware.
        /// </param>
        /// <param name="sku">
        /// The SKU of the hardware.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareListResponseItem(
            string? name,
            string? sku)
        {
            this.Name = name;
            this.Sku = sku;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareListResponseItem" /> class.
        /// </summary>
        public HardwareListResponseItem()
        {
        }
    }
}