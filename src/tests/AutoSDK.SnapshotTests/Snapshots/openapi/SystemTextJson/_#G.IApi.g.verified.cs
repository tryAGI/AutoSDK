//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Staking Platform Api<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ReportsClient Reports { get; }

        /// <summary>
        /// 
        /// </summary>
        public DownlineClient Downline { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrdersClient Orders { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProductsClient Products { get; }

        /// <summary>
        /// 
        /// </summary>
        public WalletsClient Wallets { get; }

        /// <summary>
        /// 
        /// </summary>
        public DiscountsClient Discounts { get; }

        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommissionPoolClient CommissionPool { get; }

        /// <summary>
        /// 
        /// </summary>
        public CountryClient Country { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomerClient Customer { get; }

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard { get; }

        /// <summary>
        /// 
        /// </summary>
        public FundTransferRequestClient FundTransferRequest { get; }

        /// <summary>
        /// 
        /// </summary>
        public FundWithdrawalRequestClient FundWithdrawalRequest { get; }

        /// <summary>
        /// 
        /// </summary>
        public InfinityBonusClient InfinityBonus { get; }

        /// <summary>
        /// 
        /// </summary>
        public NetworkBonusItemsClient NetworkBonusItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public OneTimePasswordClient OneTimePassword { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrderClient Order { get; }

        /// <summary>
        /// 
        /// </summary>
        public PayoutDetailsItemClient PayoutDetailsItem { get; }

        /// <summary>
        /// 
        /// </summary>
        public PayoutDetailsItemVolumeBoostClient PayoutDetailsItemVolumeBoost { get; }

        /// <summary>
        /// 
        /// </summary>
        public PayoutPeriodCommissionPoolSummaryClient PayoutPeriodCommissionPoolSummary { get; }

        /// <summary>
        /// 
        /// </summary>
        public PayoutPeriodClient PayoutPeriod { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProductClient Product { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProductSubscriptionClient ProductSubscription { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromotionalEventClient PromotionalEvent { get; }

        /// <summary>
        /// 
        /// </summary>
        public RankAchievementClient RankAchievement { get; }

        /// <summary>
        /// 
        /// </summary>
        public RankPeriodClient RankPeriod { get; }

        /// <summary>
        /// 
        /// </summary>
        public RankRewardClaimClient RankRewardClaim { get; }

        /// <summary>
        /// 
        /// </summary>
        public RanksClient Ranks { get; }

        /// <summary>
        /// 
        /// </summary>
        public SupportedCultureClient SupportedCulture { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public VersionClient Version { get; }

        /// <summary>
        /// 
        /// </summary>
        public WalletFundingRequestClient WalletFundingRequest { get; }

        /// <summary>
        /// 
        /// </summary>
        public WalletTransactionClient WalletTransaction { get; }

        /// <summary>
        /// 
        /// </summary>
        public XGatewayClient XGateway { get; }

    }
}