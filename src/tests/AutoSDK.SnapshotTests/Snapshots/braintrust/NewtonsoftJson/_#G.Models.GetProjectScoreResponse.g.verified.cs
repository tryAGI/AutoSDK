//HintName: G.Models.GetProjectScoreResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectScoreResponse
    {
        /// <summary>
        /// A list of project_score objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProjectScore> Objects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectScoreResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of project_score objects
        /// </param>
        public GetProjectScoreResponse(
            global::System.Collections.Generic.IList<global::G.ProjectScore> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectScoreResponse" /> class.
        /// </summary>
        public GetProjectScoreResponse()
        {
        }
    }
}