//HintName: G.Models.BulkConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOperations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPayloadSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPayloadSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkConfig" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxOperations"></param>
        /// <param name="maxPayloadSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkConfig(
            bool supported,
            int maxOperations,
            int maxPayloadSize)
        {
            this.Supported = supported;
            this.MaxOperations = maxOperations;
            this.MaxPayloadSize = maxPayloadSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkConfig" /> class.
        /// </summary>
        public BulkConfig()
        {
        }
    }
}