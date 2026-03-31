//HintName: G.Models.CreateStreamResponseIceServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamResponseIceServer
    {
        /// <summary>
        /// URL of the server - can be multiple addresses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> Urls { get; set; }

        /// <summary>
        /// Username for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Credintials for secure connection to the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamResponseIceServer" /> class.
        /// </summary>
        /// <param name="urls">
        /// URL of the server - can be multiple addresses
        /// </param>
        /// <param name="username">
        /// Username for authentication
        /// </param>
        /// <param name="credential">
        /// Credintials for secure connection to the server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStreamResponseIceServer(
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> urls,
            string? username,
            string? credential)
        {
            this.Urls = urls;
            this.Username = username;
            this.Credential = credential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamResponseIceServer" /> class.
        /// </summary>
        public CreateStreamResponseIceServer()
        {
        }
    }
}