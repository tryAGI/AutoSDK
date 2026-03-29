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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the connected account was successfully deleted
        /// </param>
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