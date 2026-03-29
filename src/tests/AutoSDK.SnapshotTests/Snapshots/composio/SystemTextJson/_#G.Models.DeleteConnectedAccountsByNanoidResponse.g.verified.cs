//HintName: G.Models.DeleteConnectedAccountsByNanoidResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response returned after successfully deleting a connected account<br/>
    /// Example: {"success":true}
    /// </summary>
    public sealed partial class DeleteConnectedAccountsByNanoidResponse
    {
        /// <summary>
        /// Indicates whether the connected account was successfully deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the connected account was successfully deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteConnectedAccountsByNanoidResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        public DeleteConnectedAccountsByNanoidResponse()
        {
        }
    }
}