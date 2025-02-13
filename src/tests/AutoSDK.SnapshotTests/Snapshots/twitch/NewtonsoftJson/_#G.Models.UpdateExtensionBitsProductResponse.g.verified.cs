﻿//HintName: G.Models.UpdateExtensionBitsProductResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExtensionBitsProductResponse
    {
        /// <summary>
        /// A list of Bits products that the extension created. The list is in ascending SKU order. The list is empty if the extension hasn't created any products or they're all expired or disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtensionBitsProduct> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of Bits products that the extension created. The list is in ascending SKU order. The list is empty if the extension hasn't created any products or they're all expired or disabled.
        /// </param>
        public UpdateExtensionBitsProductResponse(
            global::System.Collections.Generic.IList<global::G.ExtensionBitsProduct> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductResponse" /> class.
        /// </summary>
        public UpdateExtensionBitsProductResponse()
        {
        }
    }
}