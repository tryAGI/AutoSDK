//HintName: G.Models.ShareOptionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShareOptionResponseModel
    {
        /// <summary>
        /// The name of the principal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the principal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the principal: user, group, or workspace api key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShareOptionResponseModelType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareOptionResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the principal.
        /// </param>
        /// <param name="id">
        /// The ID of the principal.
        /// </param>
        /// <param name="type">
        /// The type of the principal: user, group, or workspace api key.
        /// </param>
        public ShareOptionResponseModel(
            string name,
            string id,
            global::G.ShareOptionResponseModelType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareOptionResponseModel" /> class.
        /// </summary>
        public ShareOptionResponseModel()
        {
        }
    }
}