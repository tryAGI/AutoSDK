﻿//HintName: G.Models.ListNamespaceSecretsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListNamespaceSecretsResponse contains a list of secrets.
    /// </summary>
    public sealed partial class ListNamespaceSecretsResponse
    {
        /// <summary>
        /// A list of secret resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets")]
        public global::System.Collections.Generic.IList<global::G.Secret>? Secrets { get; set; }

        /// <summary>
        /// Next page secret.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of secret resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceSecretsResponse" /> class.
        /// </summary>
        /// <param name="secrets">
        /// A list of secret resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page secret.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of secret resources.<br/>
        /// Included only in responses
        /// </param>
        public ListNamespaceSecretsResponse(
            global::System.Collections.Generic.IList<global::G.Secret>? secrets,
            string? nextPageToken,
            int? totalSize)
        {
            this.Secrets = secrets;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceSecretsResponse" /> class.
        /// </summary>
        public ListNamespaceSecretsResponse()
        {
        }
    }
}