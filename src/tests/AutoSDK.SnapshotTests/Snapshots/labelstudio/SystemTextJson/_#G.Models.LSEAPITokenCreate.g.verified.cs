//HintName: G.Models.LSEAPITokenCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LSEAPITokenCreate
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEAPITokenCreate" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="expiresAt">
        /// Included only in responses
        /// </param>
        /// <param name="token">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LSEAPITokenCreate(
            string createdAt = default!,
            string expiresAt = default!,
            string token = default!)
        {
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEAPITokenCreate" /> class.
        /// </summary>
        public LSEAPITokenCreate()
        {
        }
    }
}