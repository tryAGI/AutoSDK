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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationsBulkCreateResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Annotation ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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