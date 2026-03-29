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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentStreamRequestPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="projectName"></param>
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