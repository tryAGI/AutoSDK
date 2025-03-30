//HintName: G.Models.GroupedExamplesWithRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Grouped examples with runs.
    /// </summary>
    public sealed partial class GroupedExamplesWithRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groups", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExampleWithRunsGroup> Groups { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExamplesWithRunsResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
        public GroupedExamplesWithRunsResponse(
            global::System.Collections.Generic.IList<global::G.ExampleWithRunsGroup> groups)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExamplesWithRunsResponse" /> class.
        /// </summary>
        public GroupedExamplesWithRunsResponse()
        {
        }
    }
}