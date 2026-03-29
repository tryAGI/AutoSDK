//HintName: G.Models.LSAPITokenRotateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LSAPITokenRotateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refresh", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refresh { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSAPITokenRotateRequest" /> class.
        /// </summary>
        /// <param name="refresh"></param>
        public LSAPITokenRotateRequest(
            string refresh)
        {
            this.Refresh = refresh ?? throw new global::System.ArgumentNullException(nameof(refresh));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSAPITokenRotateRequest" /> class.
        /// </summary>
        public LSAPITokenRotateRequest()
        {
        }
    }
}