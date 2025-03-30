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
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExampleWithRunsGroup> Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExamplesWithRunsResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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