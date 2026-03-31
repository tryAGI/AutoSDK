//HintName: G.Models.PickExpressiveVideoIdOrStatusOrCreatedAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickExpressiveVideoIdOrStatusOrCreatedAt
    {
        /// <summary>
        /// The id of the expressive video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PickExpressiveVideoIdOrStatusOrCreatedAtStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PickExpressiveVideoIdOrStatusOrCreatedAtStatus Status { get; set; }

        /// <summary>
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoIdOrStatusOrCreatedAt" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expressive video
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickExpressiveVideoIdOrStatusOrCreatedAt(
            string id,
            global::G.PickExpressiveVideoIdOrStatusOrCreatedAtStatus status,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoIdOrStatusOrCreatedAt" /> class.
        /// </summary>
        public PickExpressiveVideoIdOrStatusOrCreatedAt()
        {
        }
    }
}