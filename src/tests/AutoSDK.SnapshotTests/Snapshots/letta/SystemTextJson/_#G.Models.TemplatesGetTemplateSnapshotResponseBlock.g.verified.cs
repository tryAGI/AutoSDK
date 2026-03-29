//HintName: G.Models.TemplatesGetTemplateSnapshotResponseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveOnMigration")]
        public bool? PreserveOnMigration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseBlock" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="limit"></param>
        /// <param name="description"></param>
        /// <param name="readOnly"></param>
        /// <param name="preserveOnMigration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseBlock(
            string entityId,
            string label,
            string value,
            double limit,
            string description,
            bool readOnly,
            bool? preserveOnMigration)
        {
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Limit = limit;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PreserveOnMigration = preserveOnMigration;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseBlock" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseBlock()
        {
        }
    }
}