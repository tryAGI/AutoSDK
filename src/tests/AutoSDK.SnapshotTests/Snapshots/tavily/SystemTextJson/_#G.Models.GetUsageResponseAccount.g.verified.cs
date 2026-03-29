//HintName: G.Models.GetUsageResponseAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Account plan and usage information
    /// </summary>
    public sealed partial class GetUsageResponseAccount
    {
        /// <summary>
        /// The current subscription plan name<br/>
        /// Example: Bootstrap
        /// </summary>
        /// <example>Bootstrap</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_plan")]
        public string? CurrentPlan { get; set; }

        /// <summary>
        /// Total credits used for this plan during the current billing cycle<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_usage")]
        public int? PlanUsage { get; set; }

        /// <summary>
        /// Usage limit for the current plan<br/>
        /// Example: 15000
        /// </summary>
        /// <example>15000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_limit")]
        public int? PlanLimit { get; set; }

        /// <summary>
        /// Current pay-as-you-go usage count<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paygo_usage")]
        public int? PaygoUsage { get; set; }

        /// <summary>
        /// Pay-as-you-go usage limit<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paygo_limit")]
        public int? PaygoLimit { get; set; }

        /// <summary>
        /// Search endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 350
        /// </summary>
        /// <example>350</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_usage")]
        public int? SearchUsage { get; set; }

        /// <summary>
        /// Extract endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_usage")]
        public int? ExtractUsage { get; set; }

        /// <summary>
        /// Crawl endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl_usage")]
        public int? CrawlUsage { get; set; }

        /// <summary>
        /// Map endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_usage")]
        public int? MapUsage { get; set; }

        /// <summary>
        /// Research endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("research_usage")]
        public int? ResearchUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseAccount" /> class.
        /// </summary>
        /// <param name="currentPlan">
        /// The current subscription plan name<br/>
        /// Example: Bootstrap
        /// </param>
        /// <param name="planUsage">
        /// Total credits used for this plan during the current billing cycle<br/>
        /// Example: 500
        /// </param>
        /// <param name="planLimit">
        /// Usage limit for the current plan<br/>
        /// Example: 15000
        /// </param>
        /// <param name="paygoUsage">
        /// Current pay-as-you-go usage count<br/>
        /// Example: 25
        /// </param>
        /// <param name="paygoLimit">
        /// Pay-as-you-go usage limit<br/>
        /// Example: 100
        /// </param>
        /// <param name="searchUsage">
        /// Search endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 350
        /// </param>
        /// <param name="extractUsage">
        /// Extract endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 75
        /// </param>
        /// <param name="crawlUsage">
        /// Crawl endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 50
        /// </param>
        /// <param name="mapUsage">
        /// Map endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 15
        /// </param>
        /// <param name="researchUsage">
        /// Research endpoint credits used for this plan during the current billing cycle<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseAccount(
            string? currentPlan,
            int? planUsage,
            int? planLimit,
            int? paygoUsage,
            int? paygoLimit,
            int? searchUsage,
            int? extractUsage,
            int? crawlUsage,
            int? mapUsage,
            int? researchUsage)
        {
            this.CurrentPlan = currentPlan;
            this.PlanUsage = planUsage;
            this.PlanLimit = planLimit;
            this.PaygoUsage = paygoUsage;
            this.PaygoLimit = paygoLimit;
            this.SearchUsage = searchUsage;
            this.ExtractUsage = extractUsage;
            this.CrawlUsage = crawlUsage;
            this.MapUsage = mapUsage;
            this.ResearchUsage = researchUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseAccount" /> class.
        /// </summary>
        public GetUsageResponseAccount()
        {
        }
    }
}