//HintName: G.Models.ResearchDtoClassDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchDtoClassDiscriminatorStatusJsonConverter))]
        public global::G.ResearchDtoClassDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
        public ResearchDtoClassDiscriminator(
            global::G.ResearchDtoClassDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassDiscriminator" /> class.
        /// </summary>
        public ResearchDtoClassDiscriminator()
        {
        }

    }
}