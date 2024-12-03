//HintName: G.Models.GistsCreateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsCreateRequest
    {
        /// <summary>
        /// Description of the gist<br/>
        /// Example: Example Ruby script
        /// </summary>
        /// <example>Example Ruby script</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names and content for the files that make up the gist
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.GistsCreateRequestFiles2> Files { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public")]
        public global::G.OneOf<bool?, global::G.GistsCreateRequestPublic?>? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of the gist<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="files">
        /// Names and content for the files that make up the gist
        /// </param>
        /// <param name="public"></param>
        public GistsCreateRequest(
            global::System.Collections.Generic.Dictionary<string, global::G.GistsCreateRequestFiles2> files,
            string? description,
            global::G.OneOf<bool?, global::G.GistsCreateRequestPublic?>? @public)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Description = description;
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequest" /> class.
        /// </summary>
        public GistsCreateRequest()
        {
        }
    }
}