﻿//HintName: G.Models.PatchedAPIKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAPIKey
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// A free-form name for the API key. Need not be unique. 50 characters max.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Once API key expires, clients cannot use it anymore.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAPIKey" /> class.
        /// </summary>
        /// <param name="prefix">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// A free-form name for the API key. Need not be unique. 50 characters max.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="expiryDate">
        /// Once API key expires, clients cannot use it anymore.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="revoked">
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAPIKey(
            string? prefix,
            global::System.DateTime? created,
            string? creator,
            string? name,
            global::System.DateTime? expiryDate,
            bool? revoked)
        {
            this.Prefix = prefix;
            this.Created = created;
            this.Creator = creator;
            this.Name = name;
            this.ExpiryDate = expiryDate;
            this.Revoked = revoked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAPIKey" /> class.
        /// </summary>
        public PatchedAPIKey()
        {
        }
    }
}