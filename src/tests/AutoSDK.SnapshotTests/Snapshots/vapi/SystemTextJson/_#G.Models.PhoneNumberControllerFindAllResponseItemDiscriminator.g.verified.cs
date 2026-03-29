//HintName: G.Models.PhoneNumberControllerFindAllResponseItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberControllerFindAllResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberControllerFindAllResponseItemDiscriminatorProviderJsonConverter))]
        public global::G.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberControllerFindAllResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberControllerFindAllResponseItemDiscriminator(
            global::G.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberControllerFindAllResponseItemDiscriminator" /> class.
        /// </summary>
        public PhoneNumberControllerFindAllResponseItemDiscriminator()
        {
        }
    }
}