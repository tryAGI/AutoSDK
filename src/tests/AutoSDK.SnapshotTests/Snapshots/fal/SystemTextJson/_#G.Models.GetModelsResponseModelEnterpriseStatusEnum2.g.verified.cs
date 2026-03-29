//HintName: G.Models.GetModelsResponseModelEnterpriseStatusEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error encountered while expanding enterprise status
    /// </summary>
    public sealed partial class GetModelsResponseModelEnterpriseStatusEnum2
    {
        /// <summary>
        /// Error details for failed enterprise status expansion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetModelsResponseModelEnterpriseStatusEnumError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelEnterpriseStatusEnum2" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details for failed enterprise status expansion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseModelEnterpriseStatusEnum2(
            global::G.GetModelsResponseModelEnterpriseStatusEnumError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelEnterpriseStatusEnum2" /> class.
        /// </summary>
        public GetModelsResponseModelEnterpriseStatusEnum2()
        {
        }
    }
}