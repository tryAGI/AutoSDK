//HintName: G.Models.JsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="schema"></param>
        /// <param name="strict">
        /// Default Value: false
        /// </param>
        public JsonSchema(
            string name,
            object schema,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Description = description;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        public JsonSchema()
        {
        }
    }
}