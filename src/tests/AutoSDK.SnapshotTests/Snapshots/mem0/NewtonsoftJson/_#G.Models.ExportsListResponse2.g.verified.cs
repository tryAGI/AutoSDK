//HintName: G.Models.ExportsListResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsListResponse2
    {
        /// <summary>
        /// Example: One of the filters: app_id, user_id, agent_id, run_id is required!
        /// </summary>
        /// <example>One of the filters: app_id, user_id, agent_id, run_id is required!</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: One of the filters: app_id, user_id, agent_id, run_id is required!
        /// </param>
        public ExportsListResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListResponse2" /> class.
        /// </summary>
        public ExportsListResponse2()
        {
        }
    }
}