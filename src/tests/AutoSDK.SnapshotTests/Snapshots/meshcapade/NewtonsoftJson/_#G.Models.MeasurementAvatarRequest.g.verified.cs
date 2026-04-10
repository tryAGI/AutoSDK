//HintName: G.Models.MeasurementAvatarRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasurementAvatarRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenderJsonConverter))]
        public global::G.Gender? Gender { get; set; }

        /// <summary>
        /// Key-value pairs of measurement names to values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("measurements")]
        public global::System.Collections.Generic.Dictionary<string, double>? Measurements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelVersionJsonConverter))]
        public global::G.ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementAvatarRequest" /> class.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="measurements">
        /// Key-value pairs of measurement names to values
        /// </param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        public MeasurementAvatarRequest(
            global::G.Gender? gender,
            global::System.Collections.Generic.Dictionary<string, double>? measurements,
            global::G.ModelVersion? modelVersion,
            string? name)
        {
            this.Gender = gender;
            this.Measurements = measurements;
            this.ModelVersion = modelVersion;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementAvatarRequest" /> class.
        /// </summary>
        public MeasurementAvatarRequest()
        {
        }
    }
}