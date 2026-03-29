//HintName: G.Models.RequestResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestResponseObject
    {
        /// <summary>
        /// The body content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Headers if present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// URL if present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// HTTP method if present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseObject" /> class.
        /// </summary>
        /// <param name="body">
        /// The body content
        /// </param>
        /// <param name="headers">
        /// Headers if present
        /// </param>
        /// <param name="url">
        /// URL if present
        /// </param>
        /// <param name="method">
        /// HTTP method if present
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestResponseObject(
            object? body,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? url,
            string? method)
        {
            this.Body = body;
            this.Headers = headers;
            this.Url = url;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseObject" /> class.
        /// </summary>
        public RequestResponseObject()
        {
        }
    }
}