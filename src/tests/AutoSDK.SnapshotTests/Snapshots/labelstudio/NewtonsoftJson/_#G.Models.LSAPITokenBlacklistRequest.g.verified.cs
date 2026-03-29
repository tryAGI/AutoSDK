//HintName: G.Models.LSAPITokenBlacklistRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LSAPITokenBlacklistRequest
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refresh")]
        public string? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSAPITokenBlacklistRequest" /> class.
        /// </summary>
        /// <param name="refresh">
        /// Included only in requests
        /// </param>
        public LSAPITokenBlacklistRequest(
            string? refresh)
        {
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSAPITokenBlacklistRequest" /> class.
        /// </summary>
        public LSAPITokenBlacklistRequest()
        {
        }
    }
}