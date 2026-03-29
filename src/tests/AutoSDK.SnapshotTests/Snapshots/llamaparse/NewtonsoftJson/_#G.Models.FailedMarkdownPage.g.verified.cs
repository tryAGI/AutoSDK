//HintName: G.Models.FailedMarkdownPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailedMarkdownPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNumber { get; set; } = default!;

        /// <summary>
        /// Error message describing the failure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Failure indicator
        /// </summary>
        /// <default>false</default>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedMarkdownPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="error">
        /// Error message describing the failure
        /// </param>
        /// <param name="success">
        /// Failure indicator
        /// </param>
        public FailedMarkdownPage(
            int pageNumber,
            string error,
            bool success = false)
        {
            this.PageNumber = pageNumber;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedMarkdownPage" /> class.
        /// </summary>
        public FailedMarkdownPage()
        {
        }
    }
}