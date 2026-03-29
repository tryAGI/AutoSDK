//HintName: G.Models.DeleteProviderKeyResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteProviderKeyResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerName", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteProviderKeyResponseVariant1ProviderName ProviderName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProviderKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="providerName"></param>
        public DeleteProviderKeyResponseVariant1(
            global::G.DeleteProviderKeyResponseVariant1ProviderName providerName)
        {
            this.ProviderName = providerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProviderKeyResponseVariant1" /> class.
        /// </summary>
        public DeleteProviderKeyResponseVariant1()
        {
        }
    }
}