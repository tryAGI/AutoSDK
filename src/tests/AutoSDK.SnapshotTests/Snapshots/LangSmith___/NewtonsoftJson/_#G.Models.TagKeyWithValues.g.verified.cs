//HintName: G.Models.TagKeyWithValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagKeyWithValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.IList<global::G.TagValue>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagKeyWithValues" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="values"></param>
        public TagKeyWithValues(
            string key,
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::System.Collections.Generic.IList<global::G.TagValue>? values)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagKeyWithValues" /> class.
        /// </summary>
        public TagKeyWithValues()
        {
        }
    }
}