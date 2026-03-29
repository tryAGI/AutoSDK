//HintName: G.Models.Index.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An index groups one or more videos stored as vectors and is the most granular level at which you can perform a search.
    /// </summary>
    public sealed partial class Index
    {
        /// <summary>
        /// A string representing the unique identifier of the index. It is assigned by the platform when an index is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the index was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the index has been updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when your index will expire.<br/>
        /// If you're on the Free plan, the platform retains your index data for 90 days from creation. After this period, the platform deletes your index data, and this action cannot be undone. To continue using your index beyond this period, consider upgrading to the Developer plan, which offers unlimited index retention. For details, see the [Upgrade your plan](/v1.3/docs/get-started/manage-your-plan#upgrade-your-plan) section.<br/>
        /// If you're on the Developer plan, this field is set to `null`, indicating no expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// A string representing the name of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// A number representing the total duration, in seconds, of the videos in the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration")]
        public double? TotalDuration { get; set; }

        /// <summary>
        /// The number of videos uploaded to this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_count")]
        public double? VideoCount { get; set; }

        /// <summary>
        /// An array containing the list of the [video understanding models](/v1.3/docs/concepts/models) enabled for this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::G.IndexModelsItems>? Models { get; set; }

        /// <summary>
        /// The list of the add-ons that are enabled for this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addons")]
        public global::System.Collections.Generic.IList<string>? Addons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Index" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of the index. It is assigned by the platform when an index is created.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the index was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the index has been updated.
        /// </param>
        /// <param name="expiresAt">
        /// A string representing the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when your index will expire.<br/>
        /// If you're on the Free plan, the platform retains your index data for 90 days from creation. After this period, the platform deletes your index data, and this action cannot be undone. To continue using your index beyond this period, consider upgrading to the Developer plan, which offers unlimited index retention. For details, see the [Upgrade your plan](/v1.3/docs/get-started/manage-your-plan#upgrade-your-plan) section.<br/>
        /// If you're on the Developer plan, this field is set to `null`, indicating no expiration.
        /// </param>
        /// <param name="indexName">
        /// A string representing the name of the index.
        /// </param>
        /// <param name="totalDuration">
        /// A number representing the total duration, in seconds, of the videos in the index.
        /// </param>
        /// <param name="videoCount">
        /// The number of videos uploaded to this index.
        /// </param>
        /// <param name="models">
        /// An array containing the list of the [video understanding models](/v1.3/docs/concepts/models) enabled for this index.
        /// </param>
        /// <param name="addons">
        /// The list of the add-ons that are enabled for this index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Index(
            string? id,
            string? createdAt,
            string? updatedAt,
            string? expiresAt,
            string? indexName,
            double? totalDuration,
            double? videoCount,
            global::System.Collections.Generic.IList<global::G.IndexModelsItems>? models,
            global::System.Collections.Generic.IList<string>? addons)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExpiresAt = expiresAt;
            this.IndexName = indexName;
            this.TotalDuration = totalDuration;
            this.VideoCount = videoCount;
            this.Models = models;
            this.Addons = addons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Index" /> class.
        /// </summary>
        public Index()
        {
        }
    }
}