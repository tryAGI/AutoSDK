//HintName: G.Models.DataFetchConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataFetchConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A list of additional headers to be added to the input fetch request when using http or https. This is intended to support authentication or authorization, for example by supplying an OAuth2 bearer token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_headers")]
        public global::System.Collections.Generic.IList<string>? AuthHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFetchConfig" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="authHeaders">
        /// A list of additional headers to be added to the input fetch request when using http or https. This is intended to support authentication or authorization, for example by supplying an OAuth2 bearer token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataFetchConfig(
            string url,
            global::System.Collections.Generic.IList<string>? authHeaders)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AuthHeaders = authHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFetchConfig" /> class.
        /// </summary>
        public DataFetchConfig()
        {
        }
    }
}