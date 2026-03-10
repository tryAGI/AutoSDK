//HintName: G.Models.ListPhoneNumbersRouteResponseItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPhoneNumbersRouteResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter))]
        public global::G.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhoneNumbersRouteResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPhoneNumbersRouteResponseItemDiscriminator(
            global::G.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhoneNumbersRouteResponseItemDiscriminator" /> class.
        /// </summary>
        public ListPhoneNumbersRouteResponseItemDiscriminator()
        {
        }
    }
}