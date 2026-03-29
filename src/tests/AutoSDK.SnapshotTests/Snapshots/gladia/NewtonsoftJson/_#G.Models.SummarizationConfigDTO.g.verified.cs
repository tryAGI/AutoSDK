//HintName: G.Models.SummarizationConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationConfigDTO
    {
        /// <summary>
        /// The type of summarization to apply<br/>
        /// Default Value: general
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SummaryTypesEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationConfigDTO" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of summarization to apply<br/>
        /// Default Value: general
        /// </param>
        public SummarizationConfigDTO(
            global::G.SummaryTypesEnum? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationConfigDTO" /> class.
        /// </summary>
        public SummarizationConfigDTO()
        {
        }
    }
}