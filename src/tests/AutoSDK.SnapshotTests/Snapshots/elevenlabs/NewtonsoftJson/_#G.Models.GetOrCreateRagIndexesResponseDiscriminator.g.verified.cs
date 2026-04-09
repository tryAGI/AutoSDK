//HintName: G.Models.GetOrCreateRagIndexesResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrCreateRagIndexesResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter))]
        public global::G.GetOrCreateRagIndexesResponseDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateRagIndexesResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
        public GetOrCreateRagIndexesResponseDiscriminator(
            global::G.GetOrCreateRagIndexesResponseDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateRagIndexesResponseDiscriminator" /> class.
        /// </summary>
        public GetOrCreateRagIndexesResponseDiscriminator()
        {
        }
    }
}