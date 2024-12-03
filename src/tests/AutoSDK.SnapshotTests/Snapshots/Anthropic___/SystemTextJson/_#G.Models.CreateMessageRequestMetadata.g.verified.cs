//HintName: G.Models.CreateMessageRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object describing metadata about the request.
    /// </summary>
    public sealed partial class CreateMessageRequestMetadata
    {
        /// <summary>
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use<br/>
        /// this id to help detect abuse. Do not include any identifying information such as<br/>
        /// name, email address, or phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestMetadata" /> class.
        /// </summary>
        /// <param name="userId">
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use<br/>
        /// this id to help detect abuse. Do not include any identifying information such as<br/>
        /// name, email address, or phone number.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateMessageRequestMetadata(
            string? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestMetadata" /> class.
        /// </summary>
        public CreateMessageRequestMetadata()
        {
        }
    }
}