//HintName: G.Models.Account.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Account
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("billingUrl")]
        public string BillingUrl { get; set; } = default!;

        /// <summary>
        /// How much free time has been used by previous (or ongoing) calls.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("freeTimeUsed")]
        public string FreeTimeUsed { get; set; } = default!;

        /// <summary>
        /// How much free call time this account has remaining. (This could increase if an existing call ends without using its maximum duration or an unjoined call times out.)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("freeTimeRemaining")]
        public string FreeTimeRemaining { get; set; } = default!;

        /// <summary>
        /// Whether the account has an active subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasActiveSubscription", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasActiveSubscription { get; set; } = default!;

        /// <summary>
        /// The number of active calls for this account.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("activeCalls")]
        public int ActiveCalls { get; set; } = default!;

        /// <summary>
        /// The maximum number of concurrent calls allowed for this account.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("allowedConcurrentCalls")]
        public int AllowedConcurrentCalls { get; set; } = default!;

        /// <summary>
        /// The maximum number of custom voices allowed for this account.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("allowedVoices")]
        public int AllowedVoices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="billingUrl">
        /// Included only in responses
        /// </param>
        /// <param name="freeTimeUsed">
        /// How much free time has been used by previous (or ongoing) calls.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="freeTimeRemaining">
        /// How much free call time this account has remaining. (This could increase if an existing call ends without using its maximum duration or an unjoined call times out.)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="hasActiveSubscription">
        /// Whether the account has an active subscription.
        /// </param>
        /// <param name="activeCalls">
        /// The number of active calls for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedConcurrentCalls">
        /// The maximum number of concurrent calls allowed for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedVoices">
        /// The maximum number of custom voices allowed for this account.<br/>
        /// Included only in responses
        /// </param>
        public Account(
            bool hasActiveSubscription,
            string name = default!,
            string billingUrl = default!,
            string freeTimeUsed = default!,
            string freeTimeRemaining = default!,
            int activeCalls = default!,
            int allowedConcurrentCalls = default!,
            int allowedVoices = default!)
        {
            this.HasActiveSubscription = hasActiveSubscription;
            this.Name = name;
            this.BillingUrl = billingUrl;
            this.FreeTimeUsed = freeTimeUsed;
            this.FreeTimeRemaining = freeTimeRemaining;
            this.ActiveCalls = activeCalls;
            this.AllowedConcurrentCalls = allowedConcurrentCalls;
            this.AllowedVoices = allowedVoices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
        }
    }
}