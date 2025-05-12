//HintName: G.Models.CustomChartsSection.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Guid?, string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SingleCustomChartResponse> Charts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_sections")]
        public global::System.Collections.Generic.IList<global::G.SingleCustomChartSubSectionResponse>? SubSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSection" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="charts"></param>
        /// <param name="subSections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsSection(
            string title,
            global::G.AnyOf<global::System.Guid?, string> id,
            global::System.Collections.Generic.IList<global::G.SingleCustomChartResponse> charts,
            string? description,
            int? index,
            global::System.Guid? sessionId,
            global::System.Collections.Generic.IList<global::G.SingleCustomChartSubSectionResponse>? subSections)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Id = id;
            this.Charts = charts ?? throw new global::System.ArgumentNullException(nameof(charts));
            this.Description = description;
            this.Index = index;
            this.SessionId = sessionId;
            this.SubSections = subSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSection" /> class.
        /// </summary>
        public CustomChartsSection()
        {
        }
    }
}