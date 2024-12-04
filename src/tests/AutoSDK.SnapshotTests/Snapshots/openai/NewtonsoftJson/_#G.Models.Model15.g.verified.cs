//HintName: G.Models.Model15.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes an OpenAI model offering that can be used with the API.
    /// </summary>
    public sealed partial class Model15
    {
        /// <summary>
        /// The model identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) when the model was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset Created { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "model".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ModelObject Object { get; set; }

        /// <summary>
        /// The organization that owns the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnedBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model15" /> class.
        /// </summary>
        /// <param name="id">
        /// The model identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) when the model was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "model".
        /// </param>
        /// <param name="ownedBy">
        /// The organization that owns the model.
        /// </param>
        public Model15(
            string id,
            global::System.DateTimeOffset created,
            string ownedBy,
            global::G.ModelObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model15" /> class.
        /// </summary>
        public Model15()
        {
        }
    }
}