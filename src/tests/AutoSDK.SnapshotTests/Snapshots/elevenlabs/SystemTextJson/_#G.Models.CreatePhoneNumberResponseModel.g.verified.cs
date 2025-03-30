//HintName: G.Models.CreatePhoneNumberResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneNumberResponseModel
    {
        /// <summary>
        /// Phone entity ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumberId">
        /// Phone entity ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePhoneNumberResponseModel(
            string phoneNumberId)
        {
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberResponseModel" /> class.
        /// </summary>
        public CreatePhoneNumberResponseModel()
        {
        }
    }
}