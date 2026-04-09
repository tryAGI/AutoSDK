//HintName: G.Models.CreateTokenDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTokenDTO
    {
        /// <summary>
        /// This is the tag for the token. It represents its scope.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTokenDTOTagJsonConverter))]
        public global::G.CreateTokenDTOTag? Tag { get; set; }

        /// <summary>
        /// This is the name of the token. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This are the restrictions for the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrictions")]
        public global::G.TokenRestrictions? Restrictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDTO" /> class.
        /// </summary>
        /// <param name="tag">
        /// This is the tag for the token. It represents its scope.
        /// </param>
        /// <param name="name">
        /// This is the name of the token. This is just for your own reference.
        /// </param>
        /// <param name="restrictions">
        /// This are the restrictions for the token.
        /// </param>
        public CreateTokenDTO(
            global::G.CreateTokenDTOTag? tag,
            string? name,
            global::G.TokenRestrictions? restrictions)
        {
            this.Tag = tag;
            this.Name = name;
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDTO" /> class.
        /// </summary>
        public CreateTokenDTO()
        {
        }
    }
}