//HintName: G.Models.FieldVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldId")]
        public global::System.Guid? FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("typeLabel")]
        public string? TypeLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDynamicLabel")]
        public string? IsDynamicLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldVO" /> class.
        /// </summary>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="typeLabel"></param>
        /// <param name="isDynamicLabel"></param>
        /// <param name="description"></param>
        /// <param name="sortOrder"></param>
        /// <param name="isActive"></param>
        public FieldVO(
            global::System.Guid? fieldId,
            string? title,
            string? typeLabel,
            string? isDynamicLabel,
            string? description,
            int? sortOrder,
            bool? isActive)
        {
            this.FieldId = fieldId;
            this.Title = title;
            this.TypeLabel = typeLabel;
            this.IsDynamicLabel = isDynamicLabel;
            this.Description = description;
            this.SortOrder = sortOrder;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldVO" /> class.
        /// </summary>
        public FieldVO()
        {
        }
    }
}