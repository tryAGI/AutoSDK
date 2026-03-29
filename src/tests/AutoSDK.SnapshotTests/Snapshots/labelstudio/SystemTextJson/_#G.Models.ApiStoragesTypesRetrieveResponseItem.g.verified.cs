//HintName: G.Models.ApiStoragesTypesRetrieveResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesTypesRetrieveResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesTypesRetrieveResponseItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiStoragesTypesRetrieveResponseItem(
            string? name,
            string? title)
        {
            this.Name = name;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesTypesRetrieveResponseItem" /> class.
        /// </summary>
        public ApiStoragesTypesRetrieveResponseItem()
        {
        }
    }
}