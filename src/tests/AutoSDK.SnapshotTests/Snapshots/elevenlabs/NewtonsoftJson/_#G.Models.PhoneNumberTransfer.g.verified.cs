//HintName: G.Models.PhoneNumberTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="condition"></param>
        public PhoneNumberTransfer(
            string phoneNumber,
            string condition)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        public PhoneNumberTransfer()
        {
        }
    }
}