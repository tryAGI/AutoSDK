//HintName: G.Models.PostCliCodactFailuresResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliCodactFailuresResponse
    {
        /// <summary>
        /// Whether the codact failure row was accepted for storage.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tracked { get; set; }

        /// <summary>
        /// Unique identifier for the stored failure row.<br/>
        /// Example: 5f6f7a1d-72d1-4f7c-bf3a-2fd7421bc123
        /// </summary>
        /// <example>5f6f7a1d-72d1-4f7c-bf3a-2fd7421bc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresResponse" /> class.
        /// </summary>
        /// <param name="tracked">
        /// Whether the codact failure row was accepted for storage.<br/>
        /// Example: true
        /// </param>
        /// <param name="id">
        /// Unique identifier for the stored failure row.<br/>
        /// Example: 5f6f7a1d-72d1-4f7c-bf3a-2fd7421bc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCliCodactFailuresResponse(
            bool tracked,
            string id)
        {
            this.Tracked = tracked;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresResponse" /> class.
        /// </summary>
        public PostCliCodactFailuresResponse()
        {
        }
    }
}