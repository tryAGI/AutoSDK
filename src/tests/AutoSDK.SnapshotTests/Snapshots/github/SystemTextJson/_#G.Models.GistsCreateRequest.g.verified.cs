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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names and content for the files that make up the gist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.GistsCreateRequestFiles2> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.GistsCreateRequestPublic?>))]
        public global::G.OneOf<bool?, global::G.GistsCreateRequestPublic?>? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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