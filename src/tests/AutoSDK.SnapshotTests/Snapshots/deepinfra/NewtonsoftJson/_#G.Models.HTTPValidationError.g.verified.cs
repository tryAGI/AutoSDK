//HintName: G.Models.HTTPValidationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPValidationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::System.Collections.Generic.IList<global::G.ValidationError>? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        /// <param name="detail"></param>
        public HTTPValidationError(
            global::System.Collections.Generic.IList<global::G.ValidationError>? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        public HTTPValidationError()
        {
        }
    }
}