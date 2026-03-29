//HintName: G.Models.EditInDescriptSchemaPostResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditInDescriptSchemaPostResponse
    {
        /// <summary>
        /// A url for partners to redirect their user to in order to start the import process—expires after 3 hours.<br/>
        /// Example: https://web.descript.com/import?nonce=6e3625ca-f885-460d-b2e3-e3faac79c788
        /// </summary>
        /// <example>https://web.descript.com/import?nonce=6e3625ca-f885-460d-b2e3-e3faac79c788</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// A url for partners to redirect their user to in order to start the import process—expires after 3 hours.<br/>
        /// Example: https://web.descript.com/import?nonce=6e3625ca-f885-460d-b2e3-e3faac79c788
        /// </param>
        public EditInDescriptSchemaPostResponse(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostResponse" /> class.
        /// </summary>
        public EditInDescriptSchemaPostResponse()
        {
        }
    }
}