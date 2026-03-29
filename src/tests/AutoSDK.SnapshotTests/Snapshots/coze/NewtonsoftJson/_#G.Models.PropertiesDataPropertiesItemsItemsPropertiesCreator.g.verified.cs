//HintName: G.Models.PropertiesDataPropertiesItemsItemsPropertiesCreator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesItemsItemsPropertiesCreator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesItemsItemsPropertiesCreator" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// 昵称
        /// </param>
        public PropertiesDataPropertiesItemsItemsPropertiesCreator(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesItemsItemsPropertiesCreator" /> class.
        /// </summary>
        public PropertiesDataPropertiesItemsItemsPropertiesCreator()
        {
        }
    }
}