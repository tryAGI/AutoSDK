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
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names and content for the files that make up the gist
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GistsCreateRequestFiles Files { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public")]
        public global::System.OneOf<bool, global::G.GistsCreateRequestPublic?>? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}