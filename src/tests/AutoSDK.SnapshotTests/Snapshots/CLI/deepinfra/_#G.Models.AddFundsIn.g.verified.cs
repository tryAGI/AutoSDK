﻿//HintName: G.Models.AddFundsIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddFundsIn
    {
        /// <summary>
        /// Amount to add in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsIn" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount to add in cents
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddFundsIn(
            int amount)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsIn" /> class.
        /// </summary>
        public AddFundsIn()
        {
        }
    }
}