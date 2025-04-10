//HintName: G.Models.UltravoxV1HttpCallToolDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for a CallTool implemented via HTTP requests.
    /// </summary>
    public sealed partial class UltravoxV1HttpCallToolDetails
    {
        /// <summary>
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseUrlPattern")]
        public string? BaseUrlPattern { get; set; }

        /// <summary>
        /// The HTTP method for the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("httpMethod")]
        public string? HttpMethod { get; set; }

        /// <summary>
        /// Auth headers added when the tool is invoked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authHeaders")]
        public global::System.Collections.Generic.IList<string>? AuthHeaders { get; set; }

        /// <summary>
        /// Auth query parameters added when the tool is invoked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authQueryParams")]
        public global::System.Collections.Generic.IList<string>? AuthQueryParams { get; set; }

        /// <summary>
        /// If the tool requires a call token, the scopes that must be present in the token.<br/>
        ///  If this is empty, no call token will be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callTokenScopes")]
        public global::System.Collections.Generic.IList<string>? CallTokenScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpCallToolDetails" /> class.
        /// </summary>
        /// <param name="baseUrlPattern">
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </param>
        /// <param name="httpMethod">
        /// The HTTP method for the tool.
        /// </param>
        /// <param name="authHeaders">
        /// Auth headers added when the tool is invoked.
        /// </param>
        /// <param name="authQueryParams">
        /// Auth query parameters added when the tool is invoked.
        /// </param>
        /// <param name="callTokenScopes">
        /// If the tool requires a call token, the scopes that must be present in the token.<br/>
        ///  If this is empty, no call token will be created.
        /// </param>
        public UltravoxV1HttpCallToolDetails(
            string? baseUrlPattern,
            string? httpMethod,
            global::System.Collections.Generic.IList<string>? authHeaders,
            global::System.Collections.Generic.IList<string>? authQueryParams,
            global::System.Collections.Generic.IList<string>? callTokenScopes)
        {
            this.BaseUrlPattern = baseUrlPattern;
            this.HttpMethod = httpMethod;
            this.AuthHeaders = authHeaders;
            this.AuthQueryParams = authQueryParams;
            this.CallTokenScopes = callTokenScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpCallToolDetails" /> class.
        /// </summary>
        public UltravoxV1HttpCallToolDetails()
        {
        }
    }
}