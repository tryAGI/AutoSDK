//HintName: G.Models.CreateChannelStreamScheduleSegmentBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChannelStreamScheduleSegmentBody
    {
        /// <summary>
        /// The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2021-07-01T18:00:00Z).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The time zone where the broadcast takes place. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcast recurs weekly. Is **true** if the broadcast recurs weekly. Only partners and affiliates may add non-recurring broadcasts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_recurring")]
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// The ID of the category that best represents the broadcast’s content. To get the category ID, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// The broadcast’s title. The title may contain a maximum of 140 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentBody" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2021-07-01T18:00:00Z).
        /// </param>
        /// <param name="timezone">
        /// The time zone where the broadcast takes place. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York).
        /// </param>
        /// <param name="duration">
        /// The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).
        /// </param>
        /// <param name="isRecurring">
        /// A Boolean value that determines whether the broadcast recurs weekly. Is **true** if the broadcast recurs weekly. Only partners and affiliates may add non-recurring broadcasts.
        /// </param>
        /// <param name="categoryId">
        /// The ID of the category that best represents the broadcast’s content. To get the category ID, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.
        /// </param>
        /// <param name="title">
        /// The broadcast’s title. The title may contain a maximum of 140 characters.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChannelStreamScheduleSegmentBody(
            global::System.DateTime startTime,
            string timezone,
            string duration,
            bool? isRecurring,
            string? categoryId,
            string? title)
        {
            this.StartTime = startTime;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.IsRecurring = isRecurring;
            this.CategoryId = categoryId;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentBody" /> class.
        /// </summary>
        public CreateChannelStreamScheduleSegmentBody()
        {
        }
    }
}