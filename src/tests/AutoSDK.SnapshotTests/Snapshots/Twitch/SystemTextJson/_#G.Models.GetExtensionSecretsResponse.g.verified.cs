//HintName: G.Models.GetExtensionSecretsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExtensionSecretsResponse
    {
        /// <summary>
        /// The list of shared secrets that the extension created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExtensionSecret> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionSecretsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of shared secrets that the extension created.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetExtensionSecretsResponse(
            global::System.Collections.Generic.IList<global::G.ExtensionSecret> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionSecretsResponse" /> class.
        /// </summary>
        public GetExtensionSecretsResponse()
        {
        }
    }
}