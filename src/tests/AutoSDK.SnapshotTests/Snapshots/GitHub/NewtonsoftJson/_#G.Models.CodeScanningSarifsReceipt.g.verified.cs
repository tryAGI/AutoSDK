//HintName: G.Models.CodeScanningSarifsReceipt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningSarifsReceipt
    {
        /// <summary>
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </summary>
        /// <example>6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The REST API URL for checking the status of the upload.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningSarifsReceipt" /> class.
        /// </summary>
        /// <param name="id">
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </param>
        /// <param name="url">
        /// The REST API URL for checking the status of the upload.<br/>
        /// Included only in responses
        /// </param>
        public CodeScanningSarifsReceipt(
            string? id,
            string? url)
        {
            this.Id = id;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningSarifsReceipt" /> class.
        /// </summary>
        public CodeScanningSarifsReceipt()
        {
        }
    }
}