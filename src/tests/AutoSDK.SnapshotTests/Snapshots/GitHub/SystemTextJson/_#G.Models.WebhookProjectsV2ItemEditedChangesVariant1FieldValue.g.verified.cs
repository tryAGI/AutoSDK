//HintName: G.Models.WebhookProjectsV2ItemEditedChangesVariant1FieldValue.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemEditedChangesVariant1FieldValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_node_id")]
        public string? FieldNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        public string? FieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        public int? ProjectNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>))]
        public global::G.OneOf<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>))]
        public global::G.OneOf<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1FieldValue" /> class.
        /// </summary>
        /// <param name="fieldNodeId"></param>
        /// <param name="fieldType"></param>
        /// <param name="fieldName"></param>
        /// <param name="projectNumber"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookProjectsV2ItemEditedChangesVariant1FieldValue(
            string? fieldNodeId,
            string? fieldType,
            string? fieldName,
            int? projectNumber,
            global::G.OneOf<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>? from,
            global::G.OneOf<string, int?, global::G.ProjectsV2SingleSelectOption, global::G.ProjectsV2IterationSetting>? to)
        {
            this.FieldNodeId = fieldNodeId;
            this.FieldType = fieldType;
            this.FieldName = fieldName;
            this.ProjectNumber = projectNumber;
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1FieldValue" /> class.
        /// </summary>
        public WebhookProjectsV2ItemEditedChangesVariant1FieldValue()
        {
        }
    }
}