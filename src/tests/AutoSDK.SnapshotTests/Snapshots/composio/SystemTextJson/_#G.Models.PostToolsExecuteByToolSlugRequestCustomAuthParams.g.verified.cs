//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomAuthParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom authentication parameters for tools that support parameterized authentication<br/>
    /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugRequestCustomAuthParams
    {
        /// <summary>
        /// The base URL (root address) what you should use while making http requests to the connected account. For example, for gmail, it would be 'https://gmail.googleapis.com'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::G.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? Parameters { get; set; }

        /// <summary>
        /// The body to be sent to the endpoint for authentication. This is a JSON object. Note: This is very rarely needed and is only required by very few apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomAuthParams" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// The base URL (root address) what you should use while making http requests to the connected account. For example, for gmail, it would be 'https://gmail.googleapis.com'
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="body">
        /// The body to be sent to the endpoint for authentication. This is a JSON object. Note: This is very rarely needed and is only required by very few apps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteByToolSlugRequestCustomAuthParams(
            string? baseUrl,
            global::System.Collections.Generic.IList<global::G.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? parameters,
            global::System.Collections.Generic.Dictionary<string, object?>? body)
        {
            this.BaseUrl = baseUrl;
            this.Parameters = parameters;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomAuthParams" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugRequestCustomAuthParams()
        {
        }
    }
}