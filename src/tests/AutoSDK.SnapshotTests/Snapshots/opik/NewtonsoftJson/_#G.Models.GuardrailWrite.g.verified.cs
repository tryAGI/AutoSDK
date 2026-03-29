//HintName: G.Models.GuardrailWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secondary_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SecondaryId { get; set; } = default!;

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailWriteName Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailWriteResult Result { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonNode Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonNode Details { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="secondaryId"></param>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <param name="config"></param>
        /// <param name="details"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="projectId"></param>
        public GuardrailWrite(
            global::System.Guid entityId,
            global::System.Guid secondaryId,
            global::G.GuardrailWriteName name,
            global::G.GuardrailWriteResult result,
            global::G.JsonNode config,
            global::G.JsonNode details,
            string? projectName,
            global::System.Guid? projectId)
        {
            this.EntityId = entityId;
            this.SecondaryId = secondaryId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Name = name;
            this.Result = result;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
        public GuardrailWrite()
        {
        }
    }
}