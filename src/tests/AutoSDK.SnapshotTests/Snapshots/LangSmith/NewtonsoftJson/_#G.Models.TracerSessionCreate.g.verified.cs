//HintName: G.Models.TracerSessionCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create class for TracerSession.
    /// </summary>
    public sealed partial class TracerSessionCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_tier")]
        public global::G.TraceTier? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionCreate" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        public TracerSessionCreate(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            object? extra,
            string? name,
            string? description,
            global::System.Guid? defaultDatasetId,
            global::System.Guid? referenceDatasetId,
            global::G.TraceTier? traceTier,
            global::System.Guid? id)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Name = name;
            this.Description = description;
            this.DefaultDatasetId = defaultDatasetId;
            this.ReferenceDatasetId = referenceDatasetId;
            this.TraceTier = traceTier;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionCreate" /> class.
        /// </summary>
        public TracerSessionCreate()
        {
        }
    }
}