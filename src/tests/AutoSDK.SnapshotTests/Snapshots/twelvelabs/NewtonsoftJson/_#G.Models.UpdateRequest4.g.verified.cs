//HintName: G.Models.UpdateRequest4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRequest4
    {
        /// <summary>
        /// The updated name of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The updated description of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest4" /> class.
        /// </summary>
        /// <param name="name">
        /// The updated name of the entity collection.
        /// </param>
        /// <param name="description">
        /// The updated description of the entity collection.
        /// </param>
        public UpdateRequest4(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest4" /> class.
        /// </summary>
        public UpdateRequest4()
        {
        }
    }
}