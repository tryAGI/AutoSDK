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
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteProviderKeyResponseVariant1ProviderName ProviderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProviderKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="providerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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