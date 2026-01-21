//HintName: G.Models.JobInRepositoriesVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobInRepositoriesVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.JobInRepositoriesVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInRepositoriesVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public JobInRepositoriesVariant1ItemDiscriminator(
            global::G.JobInRepositoriesVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInRepositoriesVariant1ItemDiscriminator" /> class.
        /// </summary>
        public JobInRepositoriesVariant1ItemDiscriminator()
        {
        }
    }
}