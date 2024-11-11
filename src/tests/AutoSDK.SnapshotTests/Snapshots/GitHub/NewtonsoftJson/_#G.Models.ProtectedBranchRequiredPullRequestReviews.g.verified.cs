//HintName: G.Models.ProtectedBranchRequiredPullRequestReviews.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredPullRequestReviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews")]
        public bool? DismissStaleReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_reviews")]
        public bool? RequireCodeOwnerReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_restrictions")]
        public global::G.ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_pull_request_allowances")]
        public global::G.ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviews" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dismissStaleReviews"></param>
        /// <param name="requireCodeOwnerReviews"></param>
        /// <param name="requiredApprovingReviewCount"></param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dismissalRestrictions"></param>
        /// <param name="bypassPullRequestAllowances"></param>
        public ProtectedBranchRequiredPullRequestReviews(
            string url,
            bool? dismissStaleReviews,
            bool? requireCodeOwnerReviews,
            int? requiredApprovingReviewCount,
            bool? requireLastPushApproval,
            global::G.ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions? dismissalRestrictions,
            global::G.ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances? bypassPullRequestAllowances)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DismissStaleReviews = dismissStaleReviews;
            this.RequireCodeOwnerReviews = requireCodeOwnerReviews;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.DismissalRestrictions = dismissalRestrictions;
            this.BypassPullRequestAllowances = bypassPullRequestAllowances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviews" /> class.
        /// </summary>
        public ProtectedBranchRequiredPullRequestReviews()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ProtectedBranchRequiredPullRequestReviews? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ProtectedBranchRequiredPullRequestReviews>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranchRequiredPullRequestReviews?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranchRequiredPullRequestReviews?>(serializer.Deserialize<global::G.ProtectedBranchRequiredPullRequestReviews>(jsonReader));
        }

    }
}