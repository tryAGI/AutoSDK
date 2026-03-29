//HintName: G.Models.LivekitSmartEndpointingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LivekitSmartEndpointingPlan
    {
        /// <summary>
        /// This is the provider for the smart endpointing plan.<br/>
        /// Example: livekit
        /// </summary>
        /// <example>livekit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LivekitSmartEndpointingPlanProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LivekitSmartEndpointingPlanProvider Provider { get; set; }

        /// <summary>
        /// This expression describes how long the bot will wait to start speaking based on the likelihood that the user has reached an endpoint.<br/>
        /// This is a millisecond valued function. It maps probabilities (real numbers on [0,1]) to milliseconds that the bot should wait before speaking ([0, \infty]). Any negative values that are returned are set to zero (the bot can't start talking in the past).<br/>
        /// A probability of zero represents very high confidence that the caller has stopped speaking, and would like the bot to speak to them. A probability of one represents very high confidence that the caller is still speaking.<br/>
        /// Under the hood, this is parsed into a mathjs expression. Whatever you use to write your expression needs to be valid with respect to mathjs<br/>
        /// @default "20 + 500 * sqrt(x) + 2500 * x^3"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitFunction")]
        public string? WaitFunction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LivekitSmartEndpointingPlan" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider for the smart endpointing plan.<br/>
        /// Example: livekit
        /// </param>
        /// <param name="waitFunction">
        /// This expression describes how long the bot will wait to start speaking based on the likelihood that the user has reached an endpoint.<br/>
        /// This is a millisecond valued function. It maps probabilities (real numbers on [0,1]) to milliseconds that the bot should wait before speaking ([0, \infty]). Any negative values that are returned are set to zero (the bot can't start talking in the past).<br/>
        /// A probability of zero represents very high confidence that the caller has stopped speaking, and would like the bot to speak to them. A probability of one represents very high confidence that the caller is still speaking.<br/>
        /// Under the hood, this is parsed into a mathjs expression. Whatever you use to write your expression needs to be valid with respect to mathjs<br/>
        /// @default "20 + 500 * sqrt(x) + 2500 * x^3"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LivekitSmartEndpointingPlan(
            global::G.LivekitSmartEndpointingPlanProvider provider,
            string? waitFunction)
        {
            this.Provider = provider;
            this.WaitFunction = waitFunction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LivekitSmartEndpointingPlan" /> class.
        /// </summary>
        public LivekitSmartEndpointingPlan()
        {
        }
    }
}