//HintName: G.Models.GeneratedAssetErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response data for validation and other errors returned by the Create API.
    /// </summary>
    public sealed partial class GeneratedAssetErrorResponse
    {
        /// <summary>
        /// An array of errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GeneratedAssetErrorResponseData> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetErrorResponse" /> class.
        /// </summary>
        /// <param name="errors">
        /// An array of errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedAssetErrorResponse(
            global::System.Collections.Generic.IList<global::G.GeneratedAssetErrorResponseData> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetErrorResponse" /> class.
        /// </summary>
        public GeneratedAssetErrorResponse()
        {
        }
    }
}