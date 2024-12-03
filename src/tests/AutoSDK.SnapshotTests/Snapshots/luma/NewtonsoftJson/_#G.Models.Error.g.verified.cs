//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The error object
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// The error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="detail">
        /// The error message
        /// </param>
        public Error(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}