//HintName: G.Models.Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Metadata
    {
        /// <summary>
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use this id to help detect abuse. Do not include any identifying information such as name, email address, or phone number.<br/>
        /// Example: 13803d75-b4b5-4c3e-b2a2-6f21399b021b
        /// </summary>
        /// <example>13803d75-b4b5-4c3e-b2a2-6f21399b021b</example>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="userId">
        /// An external identifier for the user who is associated with the request.<br/>
        /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use this id to help detect abuse. Do not include any identifying information such as name, email address, or phone number.<br/>
        /// Example: 13803d75-b4b5-4c3e-b2a2-6f21399b021b
        /// </param>
        public Metadata(
            string? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        public Metadata()
        {
        }
    }
}