//HintName: G.Models.CreateSupabaseCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSupabaseCredentialDTO
    {
        /// <summary>
        /// This is for supabase storage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateSupabaseCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketPlan")]
        public global::G.SupabaseBucketPlan? BucketPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSupabaseCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is for supabase storage.
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="bucketPlan"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateSupabaseCredentialDTO(
            global::G.CreateSupabaseCredentialDTOProvider provider,
            double? fallbackIndex,
            global::G.SupabaseBucketPlan? bucketPlan,
            string? name)
        {
            this.Provider = provider;
            this.FallbackIndex = fallbackIndex;
            this.BucketPlan = bucketPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSupabaseCredentialDTO" /> class.
        /// </summary>
        public CreateSupabaseCredentialDTO()
        {
        }
    }
}