//HintName: G.Models.UpdateConfigRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConfigRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("virtual_key")]
        public string? VirtualKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigRequestConfig" /> class.
        /// </summary>
        /// <param name="virtualKey"></param>
        public UpdateConfigRequestConfig(
            string? virtualKey)
        {
            this.VirtualKey = virtualKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigRequestConfig" /> class.
        /// </summary>
        public UpdateConfigRequestConfig()
        {
        }
    }
}