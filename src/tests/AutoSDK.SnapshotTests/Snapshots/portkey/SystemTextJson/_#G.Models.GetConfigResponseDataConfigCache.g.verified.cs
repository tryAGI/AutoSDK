//HintName: G.Models.GetConfigResponseDataConfigCache.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigResponseDataConfigCache
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_age")]
        public int? MaxAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigCache" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="maxAge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigResponseDataConfigCache(
            string? mode,
            int? maxAge)
        {
            this.Mode = mode;
            this.MaxAge = maxAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigCache" /> class.
        /// </summary>
        public GetConfigResponseDataConfigCache()
        {
        }
    }
}