//HintName: G.Models.DeleteRequestPayloadsResponse7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class DeleteRequestPayloadsResponse7
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteRequestPayloadsResponseError6 Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponse7" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRequestPayloadsResponse7(
            global::G.DeleteRequestPayloadsResponseError6 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponse7" /> class.
        /// </summary>
        public DeleteRequestPayloadsResponse7()
        {
        }
    }
}