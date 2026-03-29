//HintName: G.Models.EntityPersonPropertiesWorkHistoryEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single work history entry for a person.
    /// </summary>
    public sealed partial class EntityPersonPropertiesWorkHistoryEntry
    {
        /// <summary>
        /// Job title.<br/>
        /// Example: Software Engineer
        /// </summary>
        /// <example>Software Engineer</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Work location.<br/>
        /// Example: San Francisco, CA
        /// </summary>
        /// <example>San Francisco, CA</example>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dates")]
        public global::G.OneOf<global::G.EntityDateRange, object>? Dates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public global::G.OneOf<global::G.EntityPersonPropertiesCompanyRef, object>? Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonPropertiesWorkHistoryEntry" /> class.
        /// </summary>
        /// <param name="title">
        /// Job title.<br/>
        /// Example: Software Engineer
        /// </param>
        /// <param name="location">
        /// Work location.<br/>
        /// Example: San Francisco, CA
        /// </param>
        /// <param name="dates"></param>
        /// <param name="company"></param>
        public EntityPersonPropertiesWorkHistoryEntry(
            string? title,
            string? location,
            global::G.OneOf<global::G.EntityDateRange, object>? dates,
            global::G.OneOf<global::G.EntityPersonPropertiesCompanyRef, object>? company)
        {
            this.Title = title;
            this.Location = location;
            this.Dates = dates;
            this.Company = company;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonPropertiesWorkHistoryEntry" /> class.
        /// </summary>
        public EntityPersonPropertiesWorkHistoryEntry()
        {
        }
    }
}