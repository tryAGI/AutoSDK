//HintName: G.Models.PhoneNumberSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberSummary
    {
        /// <summary>
        /// The ID of the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The phone number with country code included.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the phone number.
        /// </param>
        /// <param name="number">
        /// The phone number with country code included.
        /// </param>
        public PhoneNumberSummary(
            string id,
            string number)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberSummary" /> class.
        /// </summary>
        public PhoneNumberSummary()
        {
        }
    }
}