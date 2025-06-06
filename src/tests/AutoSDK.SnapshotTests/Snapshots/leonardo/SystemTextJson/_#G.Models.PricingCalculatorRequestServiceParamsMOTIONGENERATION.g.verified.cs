﻿//HintName: G.Models.PricingCalculatorRequestServiceParamsMOTIONGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for MOTION_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsMOTIONGENERATION
    {
        /// <summary>
        /// The total duration of the motion generation in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationSeconds")]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMOTIONGENERATION" /> class.
        /// </summary>
        /// <param name="durationSeconds">
        /// The total duration of the motion generation in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsMOTIONGENERATION(
            int? durationSeconds)
        {
            this.DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMOTIONGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsMOTIONGENERATION()
        {
        }
    }
}