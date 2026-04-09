//HintName: G.Models.DatasetUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetUpdateVisibilityJsonConverter))]
        public global::G.DatasetUpdateVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="visibility"></param>
        /// <param name="tags"></param>
        public DatasetUpdate(
            string name,
            string? description,
            global::G.DatasetUpdateVisibility? visibility,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Visibility = visibility;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        public DatasetUpdate()
        {
        }
    }
}