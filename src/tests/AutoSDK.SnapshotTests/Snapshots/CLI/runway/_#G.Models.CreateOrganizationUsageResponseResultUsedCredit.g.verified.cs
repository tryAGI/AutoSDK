//HintName: G.Models.CreateOrganizationUsageResponseResultUsedCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponseResultUsedCredit
    {
        /// <summary>
        /// The model that credits were spent on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateOrganizationUsageResponseResultUsedCreditModel Model { get; set; }

        /// <summary>
        /// The number of credits spent on the model.
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
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultUsedCredit" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that credits were spent on.
        /// </param>
        /// <param name="amount">
        /// The number of credits spent on the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponseResultUsedCredit(
            global::G.CreateOrganizationUsageResponseResultUsedCreditModel model,
            int amount)
        {
            this.Model = model;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultUsedCredit" /> class.
        /// </summary>
        public CreateOrganizationUsageResponseResultUsedCredit()
        {
        }
    }
}