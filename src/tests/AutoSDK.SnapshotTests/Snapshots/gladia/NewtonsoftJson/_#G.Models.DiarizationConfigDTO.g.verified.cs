//HintName: G.Models.DiarizationConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiarizationConfigDTO
    {
        /// <summary>
        /// Exact number of speakers in the audio<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("number_of_speakers")]
        public int? NumberOfSpeakers { get; set; }

        /// <summary>
        /// Minimum number of speakers in the audio<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("min_speakers")]
        public int? MinSpeakers { get; set; }

        /// <summary>
        /// Maximum number of speakers in the audio<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("max_speakers")]
        public int? MaxSpeakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiarizationConfigDTO" /> class.
        /// </summary>
        /// <param name="numberOfSpeakers">
        /// Exact number of speakers in the audio<br/>
        /// Example: 3
        /// </param>
        /// <param name="minSpeakers">
        /// Minimum number of speakers in the audio<br/>
        /// Example: 1
        /// </param>
        /// <param name="maxSpeakers">
        /// Maximum number of speakers in the audio<br/>
        /// Example: 2
        /// </param>
        public DiarizationConfigDTO(
            int? numberOfSpeakers,
            int? minSpeakers,
            int? maxSpeakers)
        {
            this.NumberOfSpeakers = numberOfSpeakers;
            this.MinSpeakers = minSpeakers;
            this.MaxSpeakers = maxSpeakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiarizationConfigDTO" /> class.
        /// </summary>
        public DiarizationConfigDTO()
        {
        }
    }
}