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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesItemsItemsPropertiesCreator" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// 昵称
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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