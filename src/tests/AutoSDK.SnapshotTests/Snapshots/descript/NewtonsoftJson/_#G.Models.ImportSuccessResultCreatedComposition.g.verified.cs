//HintName: G.Models.ImportSuccessResultCreatedComposition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportSuccessResultCreatedComposition
    {
        /// <summary>
        /// Example: 0daabc7a-437a-43eb-b04b-b398d502f393
        /// </summary>
        /// <example>0daabc7a-437a-43eb-b04b-b398d502f393</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: Rough Cut
        /// </summary>
        /// <example>Rough Cut</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResultCreatedComposition" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 0daabc7a-437a-43eb-b04b-b398d502f393
        /// </param>
        /// <param name="name">
        /// Example: Rough Cut
        /// </param>
        public ImportSuccessResultCreatedComposition(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResultCreatedComposition" /> class.
        /// </summary>
        public ImportSuccessResultCreatedComposition()
        {
        }
    }
}