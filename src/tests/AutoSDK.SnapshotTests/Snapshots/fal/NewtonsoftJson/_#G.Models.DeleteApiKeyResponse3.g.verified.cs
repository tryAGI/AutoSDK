//HintName: G.Models.DeleteApiKeyResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class DeleteApiKeyResponse3
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteApiKeyResponseError3 Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteApiKeyResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
        public DeleteApiKeyResponse3(
            global::G.DeleteApiKeyResponseError3 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteApiKeyResponse3" /> class.
        /// </summary>
        public DeleteApiKeyResponse3()
        {
        }
    }
}