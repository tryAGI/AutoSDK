//HintName: G.Models.AddToWaitlistRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddToWaitlistRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feature", Required = global::Newtonsoft.Json.Required.Always)]
        public string Feature { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToWaitlistRequest" /> class.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="email"></param>
        public AddToWaitlistRequest(
            string feature,
            string email)
        {
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToWaitlistRequest" /> class.
        /// </summary>
        public AddToWaitlistRequest()
        {
        }
    }
}