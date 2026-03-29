//HintName: G.Models.ErrorMessageDetailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorMessageDetailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorMessageDetailed" /> class.
        /// </summary>
        /// <param name="errors"></param>
        public ErrorMessageDetailed(
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorMessageDetailed" /> class.
        /// </summary>
        public ErrorMessageDetailed()
        {
        }
    }
}