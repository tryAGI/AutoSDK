//HintName: G.Models.TestSuitePhoneNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuitePhoneNumber
    {
        /// <summary>
        /// This is the provider of the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestSuitePhoneNumberProviderJsonConverter))]
        public global::G.TestSuitePhoneNumberProvider Provider { get; set; }

        /// <summary>
        /// This is the phone number that is being tested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuitePhoneNumber" /> class.
        /// </summary>
        /// <param name="number">
        /// This is the phone number that is being tested.
        /// </param>
        /// <param name="provider">
        /// This is the provider of the phone number.
        /// </param>
        public TestSuitePhoneNumber(
            string number,
            global::G.TestSuitePhoneNumberProvider provider)
        {
            this.Provider = provider;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuitePhoneNumber" /> class.
        /// </summary>
        public TestSuitePhoneNumber()
        {
        }
    }
}