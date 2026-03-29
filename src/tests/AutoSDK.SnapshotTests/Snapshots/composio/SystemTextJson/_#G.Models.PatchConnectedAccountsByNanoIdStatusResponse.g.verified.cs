//HintName: G.Models.PatchConnectedAccountsByNanoIdStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response returned after successfully updating a connected account status<br/>
    /// Example: {"success":true}
    /// </summary>
    public sealed partial class PatchConnectedAccountsByNanoIdStatusResponse
    {
        /// <summary>
        /// Indicates whether the connected account status was successfully updated
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
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoIdStatusResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the connected account status was successfully updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountsByNanoIdStatusResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoIdStatusResponse" /> class.
        /// </summary>
        public PatchConnectedAccountsByNanoIdStatusResponse()
        {
        }
    }
}