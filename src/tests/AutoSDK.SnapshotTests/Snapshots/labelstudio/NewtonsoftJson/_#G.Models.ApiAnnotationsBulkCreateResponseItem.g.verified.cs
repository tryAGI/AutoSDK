//HintName: G.Models.ApiAnnotationsBulkCreateResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiAnnotationsBulkCreateResponseItem
    {
        /// <summary>
        /// Annotation ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationsBulkCreateResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Annotation ID
        /// </param>
        public ApiAnnotationsBulkCreateResponseItem(
            int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationsBulkCreateResponseItem" /> class.
        /// </summary>
        public ApiAnnotationsBulkCreateResponseItem()
        {
        }
    }
}