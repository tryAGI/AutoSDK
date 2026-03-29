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
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public string Position { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("layout")]
        public global::G.AnyOf<global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsSpanFieldOrderItem" /> class.
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="columnId"></param>
        /// <param name="position"></param>
        /// <param name="layout"></param>
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