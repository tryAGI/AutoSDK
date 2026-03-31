//HintName: G.Models.ProjectSettingsSpanFieldOrderItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSettingsSpanFieldOrderItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>))]
        public global::G.AnyOf<global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsSpanFieldOrderItem" /> class.
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="columnId"></param>
        /// <param name="position"></param>
        /// <param name="layout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettingsSpanFieldOrderItem(
            string objectType,
            string columnId,
            string position,
            global::G.AnyOf<global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>? layout)
        {
            this.ObjectType = objectType ?? throw new global::System.ArgumentNullException(nameof(objectType));
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.Layout = layout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsSpanFieldOrderItem" /> class.
        /// </summary>
        public ProjectSettingsSpanFieldOrderItem()
        {
        }
    }
}