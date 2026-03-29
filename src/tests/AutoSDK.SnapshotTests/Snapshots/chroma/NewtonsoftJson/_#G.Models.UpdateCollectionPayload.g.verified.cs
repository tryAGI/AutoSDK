//HintName: G.Models.UpdateCollectionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCollectionPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_configuration")]
        public global::G.OneOf<object, global::G.UpdateCollectionConfiguration>? NewConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_metadata")]
        public global::G.OneOf<object, global::G.HashMap>? NewMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name")]
        public string? NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionPayload" /> class.
        /// </summary>
        /// <param name="newConfiguration"></param>
        /// <param name="newMetadata"></param>
        /// <param name="newName"></param>
        public UpdateCollectionPayload(
            global::G.OneOf<object, global::G.UpdateCollectionConfiguration>? newConfiguration,
            global::G.OneOf<object, global::G.HashMap>? newMetadata,
            string? newName)
        {
            this.NewConfiguration = newConfiguration;
            this.NewMetadata = newMetadata;
            this.NewName = newName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionPayload" /> class.
        /// </summary>
        public UpdateCollectionPayload()
        {
        }
    }
}