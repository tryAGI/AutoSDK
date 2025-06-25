﻿//HintName: G.Models.ReposCreateAutolinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateAutolinkRequest
    {
        /// <summary>
        /// This prefix appended by certain characters will generate a link any time it is found in an issue, pull request, or commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// The URL must contain `&lt;num&gt;` for the reference number. `&lt;num&gt;` matches different characters depending on the value of `is_alphanumeric`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlTemplate { get; set; }

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If true, the `&lt;num&gt;` parameter of the `url_template` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`. If false, this autolink reference only matches numeric characters.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_alphanumeric")]
        public bool? IsAlphanumeric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAutolinkRequest" /> class.
        /// </summary>
        /// <param name="keyPrefix">
        /// This prefix appended by certain characters will generate a link any time it is found in an issue, pull request, or commit.
        /// </param>
        /// <param name="urlTemplate">
        /// The URL must contain `&lt;num&gt;` for the reference number. `&lt;num&gt;` matches different characters depending on the value of `is_alphanumeric`.
        /// </param>
        /// <param name="isAlphanumeric">
        /// Whether this autolink reference matches alphanumeric characters. If true, the `&lt;num&gt;` parameter of the `url_template` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`. If false, this autolink reference only matches numeric characters.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateAutolinkRequest(
            string keyPrefix,
            string urlTemplate,
            bool? isAlphanumeric)
        {
            this.KeyPrefix = keyPrefix ?? throw new global::System.ArgumentNullException(nameof(keyPrefix));
            this.UrlTemplate = urlTemplate ?? throw new global::System.ArgumentNullException(nameof(urlTemplate));
            this.IsAlphanumeric = isAlphanumeric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAutolinkRequest" /> class.
        /// </summary>
        public ReposCreateAutolinkRequest()
        {
        }
    }
}