//HintName: G.Models.CustomHostConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomHostConfiguration
    {
        /// <summary>
        /// Custom host URL (can be used along with other provider specific configuration fields)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_host")]
        public string? CustomHost { get; set; }

        /// <summary>
        /// Custom headers to send with requests (can be used along with other provider specific configuration fields)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHostConfiguration" /> class.
        /// </summary>
        /// <param name="customHost">
        /// Custom host URL (can be used along with other provider specific configuration fields)
        /// </param>
        /// <param name="customHeaders">
        /// Custom headers to send with requests (can be used along with other provider specific configuration fields)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomHostConfiguration(
            string? customHost,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.CustomHost = customHost;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHostConfiguration" /> class.
        /// </summary>
        public CustomHostConfiguration()
        {
        }
    }
}