//HintName: G.Models.MusicUploadResponseCompositionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The composition plan extracted from the uploaded song. Only present if `extract_composition_plan` was True in the request body
    /// </summary>
    public sealed partial class MusicUploadResponseCompositionPlan
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}