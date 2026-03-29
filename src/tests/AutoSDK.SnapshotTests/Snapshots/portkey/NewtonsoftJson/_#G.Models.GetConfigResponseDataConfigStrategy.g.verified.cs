//HintName: G.Models.GetConfigResponseDataConfigStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigResponseDataConfigStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigStrategy" /> class.
        /// </summary>
        /// <param name="mode"></param>
        public GetConfigResponseDataConfigStrategy(
            string? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigStrategy" /> class.
        /// </summary>
        public GetConfigResponseDataConfigStrategy()
        {
        }
    }
}