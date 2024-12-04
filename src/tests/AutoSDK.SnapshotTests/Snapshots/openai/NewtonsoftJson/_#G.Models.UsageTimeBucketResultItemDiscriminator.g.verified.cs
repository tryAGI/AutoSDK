//HintName: G.Models.UsageTimeBucketResultItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTimeBucketResultItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UsageTimeBucketResultItemDiscriminatorObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucketResultItemDiscriminator" /> class.
        /// </summary>
        /// <param name="object"></param>
        public UsageTimeBucketResultItemDiscriminator(
            global::G.UsageTimeBucketResultItemDiscriminatorObject? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucketResultItemDiscriminator" /> class.
        /// </summary>
        public UsageTimeBucketResultItemDiscriminator()
        {
        }
    }
}