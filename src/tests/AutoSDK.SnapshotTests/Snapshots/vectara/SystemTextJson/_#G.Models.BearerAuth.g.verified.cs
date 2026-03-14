//HintName: G.Models.BearerAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bearer token authentication
    /// </summary>
    public sealed partial class BearerAuth
    {
        /// <summary>
        /// Must be "bearer" for bearer token auth<br/>
        /// Default Value: bearer<br/>
        /// Example: bearer
        /// </summary>
        /// <default>"bearer"</default>
        /// <example>bearer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "bearer";

        /// <summary>
        /// The bearer token to use for authentication<br/>
        /// Example: abcdef......
        /// </summary>
        /// <example>abcdef......</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "bearer" for bearer token auth<br/>
        /// Default Value: bearer<br/>
        /// Example: bearer
        /// </param>
        /// <param name="token">
        /// The bearer token to use for authentication<br/>
        /// Example: abcdef......
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BearerAuth(
            string type,
            string token)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuth" /> class.
        /// </summary>
        public BearerAuth()
        {
        }
    }
}