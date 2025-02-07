//HintName: G.Models.CreateStreamMarkerBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamMarkerBody
    {
        /// <summary>
        /// The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamMarkerBody" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.
        /// </param>
        /// <param name="description">
        /// A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStreamMarkerBody(
            string userId,
            string? description)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamMarkerBody" /> class.
        /// </summary>
        public CreateStreamMarkerBody()
        {
        }
    }
}