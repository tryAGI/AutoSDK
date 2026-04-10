//HintName: G.Models.CreatePromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptResponse
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
        [global::Newtonsoft.Json.JsonProperty("version_id")]
        public global::System.Guid? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreatePromptResponseObjectJsonConverter))]
        public global::G.CreatePromptResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="versionId"></param>
        /// <param name="object"></param>
        public CreatePromptResponse(
            global::System.Guid? id,
            string? slug,
            global::System.Guid? versionId,
            global::G.CreatePromptResponseObject? @object)
        {
            this.Id = id;
            this.Slug = slug;
            this.VersionId = versionId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        public CreatePromptResponse()
        {
        }
    }
}