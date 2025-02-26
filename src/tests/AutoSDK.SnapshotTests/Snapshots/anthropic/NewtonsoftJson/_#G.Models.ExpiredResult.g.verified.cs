//HintName: G.Models.ExpiredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpiredResult
    {
        /// <summary>
        /// Default Value: expired
        /// </summary>
        /// <default>global::G.ExpiredResultType.Expired</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ExpiredResultType Type { get; set; } = global::G.ExpiredResultType.Expired;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
        public ExpiredResult(
            global::G.ExpiredResultType type = global::G.ExpiredResultType.Expired)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        public ExpiredResult()
        {
        }
    }
}