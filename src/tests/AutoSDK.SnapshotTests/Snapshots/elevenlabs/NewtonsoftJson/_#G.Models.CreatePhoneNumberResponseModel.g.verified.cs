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
        [global::Newtonsoft.Json.JsonProperty("phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumberId">
        /// Phone entity ID
        /// </param>
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