//HintName: G.Models.ListSourceLanguagesResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSourceLanguagesResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSourceLanguagesResponse3" /> class.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="errorCode"></param>
        public ListSourceLanguagesResponse3(
            string? errorMessage,
            int? errorCode)
        {
            this.ErrorMessage = errorMessage;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSourceLanguagesResponse3" /> class.
        /// </summary>
        public ListSourceLanguagesResponse3()
        {
        }
    }
}