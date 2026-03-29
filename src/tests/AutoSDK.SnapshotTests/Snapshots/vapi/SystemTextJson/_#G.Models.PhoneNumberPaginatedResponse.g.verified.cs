//HintName: G.Models.PhoneNumberPaginatedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberPaginatedResponse
    {
        /// <summary>
        /// A list of phone numbers, which can be of any provider type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.ByoPhoneNumber, global::G.TwilioPhoneNumber, global::G.VonagePhoneNumber, global::G.VapiPhoneNumber, global::G.TelnyxPhoneNumber>> Results { get; set; }

        /// <summary>
        /// Metadata about the pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PaginationMeta Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberPaginatedResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// A list of phone numbers, which can be of any provider type.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberPaginatedResponse(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ByoPhoneNumber, global::G.TwilioPhoneNumber, global::G.VonagePhoneNumber, global::G.VapiPhoneNumber, global::G.TelnyxPhoneNumber>> results,
            global::G.PaginationMeta metadata)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberPaginatedResponse" /> class.
        /// </summary>
        public PhoneNumberPaginatedResponse()
        {
        }
    }
}