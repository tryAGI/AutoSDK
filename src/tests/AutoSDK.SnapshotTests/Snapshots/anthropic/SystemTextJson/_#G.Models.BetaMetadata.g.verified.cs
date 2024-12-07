//HintName: G.Models.BetaMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMetadata
    {
        /// <summary>
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use this id to help detect abuse. Do not include any identifying information such as name, email address, or phone number.<br/>
        /// Example: 13803d75-b4b5-4c3e-b2a2-6f21399b021b
        /// </summary>
        /// <example>13803d75-b4b5-4c3e-b2a2-6f21399b021b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMetadata" /> class.
        /// </summary>
        /// <param name="userId">
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use this id to help detect abuse. Do not include any identifying information such as name, email address, or phone number.<br/>
        /// Example: 13803d75-b4b5-4c3e-b2a2-6f21399b021b
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaMetadata(
            string? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMetadata" /> class.
        /// </summary>
        public BetaMetadata()
        {
        }
    }
}