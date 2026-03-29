//HintName: G.Models.StyleDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StyleDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("availableStyles")]
        public global::System.Collections.Generic.IList<string>? AvailableStyles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleDetails" /> class.
        /// </summary>
        /// <param name="availableStyles"></param>
        /// <param name="detail"></param>
        public StyleDetails(
            global::System.Collections.Generic.IList<string>? availableStyles,
            string? detail)
        {
            this.AvailableStyles = availableStyles;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleDetails" /> class.
        /// </summary>
        public StyleDetails()
        {
        }
    }
}