//HintName: G.Models.UnauthorizedErrorBody37.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnauthorizedErrorBody37
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedErrorBody37" /> class.
        /// </summary>
        /// <param name="data"></param>
        public UnauthorizedErrorBody37(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedErrorBody37" /> class.
        /// </summary>
        public UnauthorizedErrorBody37()
        {
        }
    }
}