//HintName: G.Models.CreateExtractResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExtractResponse4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.CreateExtractResponseDetail3? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponse4" /> class.
        /// </summary>
        /// <param name="detail"></param>
        public CreateExtractResponse4(
            global::G.CreateExtractResponseDetail3? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponse4" /> class.
        /// </summary>
        public CreateExtractResponse4()
        {
        }
    }
}