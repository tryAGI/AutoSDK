//HintName: G.Models.IdSpecifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdSpecifier
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The weight of the voice or embedding in the mix. If weights do not sum to 1, they will be normalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdSpecifier" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="weight">
        /// The weight of the voice or embedding in the mix. If weights do not sum to 1, they will be normalized.
        /// </param>
        public IdSpecifier(
            string id,
            double weight)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdSpecifier" /> class.
        /// </summary>
        public IdSpecifier()
        {
        }
    }
}