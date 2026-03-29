//HintName: G.Models.CreateRequest5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest5
    {
        /// <summary>
        /// The name of the entity collection. Make sure you use a succinct and descriptive name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest5" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the entity collection. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="description">
        /// Optional description of the entity collection.
        /// </param>
        public CreateRequest5(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest5" /> class.
        /// </summary>
        public CreateRequest5()
        {
        }
    }
}