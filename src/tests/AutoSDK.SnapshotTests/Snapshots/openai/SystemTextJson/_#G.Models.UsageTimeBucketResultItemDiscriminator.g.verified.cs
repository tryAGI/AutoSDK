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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageTimeBucketResultItemDiscriminatorObjectJsonConverter))]
        public global::G.UsageTimeBucketResultItemDiscriminatorObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucketResultItemDiscriminator" /> class.
        /// </summary>
        /// <param name="object"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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