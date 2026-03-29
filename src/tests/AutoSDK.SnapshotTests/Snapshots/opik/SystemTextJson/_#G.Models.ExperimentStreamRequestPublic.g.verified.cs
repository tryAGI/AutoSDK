//HintName: G.Models.ExperimentStreamRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentStreamRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentStreamRequestPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentStreamRequestPublic(
            string name,
            int? limit,
            global::System.Guid? lastRetrievedId,
            string? projectName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Limit = limit;
            this.LastRetrievedId = lastRetrievedId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentStreamRequestPublic" /> class.
        /// </summary>
        public ExperimentStreamRequestPublic()
        {
        }
    }
}