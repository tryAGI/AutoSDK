//HintName: G.Models.ApiStoragesExportTypesRetrieveResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportTypesRetrieveResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportTypesRetrieveResponseItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="title"></param>
        public ApiStoragesExportTypesRetrieveResponseItem(
            string? name,
            string? title)
        {
            this.Name = name;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportTypesRetrieveResponseItem" /> class.
        /// </summary>
        public ApiStoragesExportTypesRetrieveResponseItem()
        {
        }
    }
}