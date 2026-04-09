//HintName: G.Models.DisplayAd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Display Ad, aka Billboard, aka Widget
    /// </summary>
    public sealed partial class DisplayAd
    {
        /// <summary>
        /// The ID of the Display Ad
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// For internal use, helps distinguish ads from one another
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_markdown", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyMarkdown { get; set; } = default!;

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// Identifies the organization to which the ad belongs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Identifies the user who created the ad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_id")]
        public int? CreatorId { get; set; }

        /// <summary>
        /// Identifies which area of site layout the ad can appear in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("placement_area", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DisplayAdPlacementAreaJsonConverter))]
        public global::G.DisplayAdPlacementArea PlacementArea { get; set; } = default!;

        /// <summary>
        /// Tags on which this ad can be displayed (blank is all/any tags)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_list")]
        public string? TagList { get; set; }

        /// <summary>
        /// Articles this ad should *not* appear on (blank means no articles are disallowed, and this ad can appear next to any/all articles). Comma-separated list of integer Article IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("article_exclude_ids")]
        public string? ArticleExcludeIds { get; set; }

        /// <summary>
        /// Specifies an group of users to show this ad to (only works with logged-in users)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audience_segment_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DisplayAdAudienceSegmentTypeJsonConverter))]
        public global::G.DisplayAdAudienceSegmentType? AudienceSegmentType { get; set; }

        /// <summary>
        /// Potentially limits visitors to whom the ad is visible<br/>
        /// Default Value: all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_to")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DisplayAdDisplayToJsonConverter))]
        public global::G.DisplayAdDisplayTo? DisplayTo { get; set; }

        /// <summary>
        /// Types of the billboards:<br/>
        /// in_house (created by admins),<br/>
        /// community (created by an entity, appears on entity's content),<br/>
        /// external ( created by an entity, or a non-entity, can appear everywhere)<br/>
        /// Default Value: in_house
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type_of")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DisplayAdTypeOfJsonConverter))]
        public global::G.DisplayAdTypeOf? TypeOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayAd" /> class.
        /// </summary>
        /// <param name="name">
        /// For internal use, helps distinguish ads from one another
        /// </param>
        /// <param name="bodyMarkdown">
        /// The text (in markdown) of the ad (required)
        /// </param>
        /// <param name="placementArea">
        /// Identifies which area of site layout the ad can appear in
        /// </param>
        /// <param name="id">
        /// The ID of the Display Ad
        /// </param>
        /// <param name="approved">
        /// Ad must be both published and approved to be in rotation
        /// </param>
        /// <param name="published">
        /// Ad must be both published and approved to be in rotation
        /// </param>
        /// <param name="organizationId">
        /// Identifies the organization to which the ad belongs
        /// </param>
        /// <param name="creatorId">
        /// Identifies the user who created the ad.
        /// </param>
        /// <param name="tagList">
        /// Tags on which this ad can be displayed (blank is all/any tags)
        /// </param>
        /// <param name="articleExcludeIds">
        /// Articles this ad should *not* appear on (blank means no articles are disallowed, and this ad can appear next to any/all articles). Comma-separated list of integer Article IDs
        /// </param>
        /// <param name="audienceSegmentType">
        /// Specifies an group of users to show this ad to (only works with logged-in users)
        /// </param>
        /// <param name="displayTo">
        /// Potentially limits visitors to whom the ad is visible<br/>
        /// Default Value: all
        /// </param>
        /// <param name="typeOf">
        /// Types of the billboards:<br/>
        /// in_house (created by admins),<br/>
        /// community (created by an entity, appears on entity's content),<br/>
        /// external ( created by an entity, or a non-entity, can appear everywhere)<br/>
        /// Default Value: in_house
        /// </param>
        public DisplayAd(
            string name,
            string bodyMarkdown,
            global::G.DisplayAdPlacementArea placementArea,
            int? id,
            bool? approved,
            bool? published,
            int? organizationId,
            int? creatorId,
            string? tagList,
            string? articleExcludeIds,
            global::G.DisplayAdAudienceSegmentType? audienceSegmentType,
            global::G.DisplayAdDisplayTo? displayTo,
            global::G.DisplayAdTypeOf? typeOf)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BodyMarkdown = bodyMarkdown ?? throw new global::System.ArgumentNullException(nameof(bodyMarkdown));
            this.Approved = approved;
            this.Published = published;
            this.OrganizationId = organizationId;
            this.CreatorId = creatorId;
            this.PlacementArea = placementArea;
            this.TagList = tagList;
            this.ArticleExcludeIds = articleExcludeIds;
            this.AudienceSegmentType = audienceSegmentType;
            this.DisplayTo = displayTo;
            this.TypeOf = typeOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayAd" /> class.
        /// </summary>
        public DisplayAd()
        {
        }
    }
}