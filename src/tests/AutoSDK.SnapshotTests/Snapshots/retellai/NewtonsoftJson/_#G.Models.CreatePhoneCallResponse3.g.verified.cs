//HintName: G.Models.CreatePhoneCallResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneCallResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreatePhoneCallResponseStatus3JsonConverter))]
        public global::G.CreatePhoneCallResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Trial has ended, please add payment method.
        /// </summary>
        /// <example>Trial has ended, please add payment method.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneCallResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Trial has ended, please add payment method.
        /// </param>
        public CreatePhoneCallResponse3(
            global::G.CreatePhoneCallResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneCallResponse3" /> class.
        /// </summary>
        public CreatePhoneCallResponse3()
        {
        }
    }
}