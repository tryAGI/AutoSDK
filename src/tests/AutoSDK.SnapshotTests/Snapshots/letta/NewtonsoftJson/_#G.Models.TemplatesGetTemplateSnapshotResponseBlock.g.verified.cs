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
        [global::Newtonsoft.Json.JsonProperty("entityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserveOnMigration")]
        public bool? PreserveOnMigration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readOnly", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ReadOnly { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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