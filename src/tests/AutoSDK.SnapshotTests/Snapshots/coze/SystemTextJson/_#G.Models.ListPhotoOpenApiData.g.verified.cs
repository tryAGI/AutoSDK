//HintName: G.Models.ListPhotoOpenApiData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPhotoOpenApiData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo_infos")]
        public global::System.Collections.Generic.IList<global::G.PhotoInfo>? PhotoInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhotoOpenApiData" /> class.
        /// </summary>
        /// <param name="photoInfos"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPhotoOpenApiData(
            global::System.Collections.Generic.IList<global::G.PhotoInfo>? photoInfos,
            int? totalCount)
        {
            this.PhotoInfos = photoInfos;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhotoOpenApiData" /> class.
        /// </summary>
        public ListPhotoOpenApiData()
        {
        }
    }
}