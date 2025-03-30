//HintName: G.Models.ResetUserPasswordResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetUserPasswordResponse
    {
        /// <summary>
        /// A one time code that can be used to reset the password. This is optional, and is only populated for some Vectara deployments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("one_time_code")]
        public string? OneTimeCode { get; set; }

        /// <summary>
        /// The link where to enter the `one_time_code`.<br/>
        /// This is optional, and is only populated for some Vectara deployments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("one_time_code_link")]
        public string? OneTimeCodeLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordResponse" /> class.
        /// </summary>
        /// <param name="oneTimeCode">
        /// A one time code that can be used to reset the password. This is optional, and is only populated for some Vectara deployments.
        /// </param>
        /// <param name="oneTimeCodeLink">
        /// The link where to enter the `one_time_code`.<br/>
        /// This is optional, and is only populated for some Vectara deployments.
        /// </param>
        public ResetUserPasswordResponse(
            string? oneTimeCode,
            string? oneTimeCodeLink)
        {
            this.OneTimeCode = oneTimeCode;
            this.OneTimeCodeLink = oneTimeCodeLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordResponse" /> class.
        /// </summary>
        public ResetUserPasswordResponse()
        {
        }
    }
}