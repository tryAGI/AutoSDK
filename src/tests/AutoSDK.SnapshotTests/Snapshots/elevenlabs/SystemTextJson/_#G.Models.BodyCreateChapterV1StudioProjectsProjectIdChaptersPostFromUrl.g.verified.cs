//HintName: G.Models.BodyCreateChapterV1StudioProjectsProjectIdChaptersPostFromUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
    /// </summary>
    public sealed partial class BodyCreateChapterV1StudioProjectsProjectIdChaptersPostFromUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}