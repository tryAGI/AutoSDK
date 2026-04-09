//HintName: G.Models.CreateSecretReferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretReferenceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter))]
        public global::G.CreateSecretReferenceResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="object"></param>
        public CreateSecretReferenceResponse(
            global::System.Guid? id,
            string? slug,
            global::G.CreateSecretReferenceResponseObject? @object)
        {
            this.Id = id;
            this.Slug = slug;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceResponse" /> class.
        /// </summary>
        public CreateSecretReferenceResponse()
        {
        }
    }
}