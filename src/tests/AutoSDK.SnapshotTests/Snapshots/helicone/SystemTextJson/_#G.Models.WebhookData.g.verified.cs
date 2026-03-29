//HintName: G.Models.WebhookData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringAny Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeData")]
        public bool? IncludeData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookData" /> class.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="includeData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookData(
            string destination,
            global::G.RecordStringAny config,
            bool? includeData)
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IncludeData = includeData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookData" /> class.
        /// </summary>
        public WebhookData()
        {
        }
    }
}