//HintName: G.Models.VideoXliffResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoXliffResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xliff", Required = global::Newtonsoft.Json.Required.Always)]
        public string Xliff { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoXliffResponse" /> class.
        /// </summary>
        /// <param name="xliff"></param>
        public VideoXliffResponse(
            string xliff)
        {
            this.Xliff = xliff ?? throw new global::System.ArgumentNullException(nameof(xliff));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoXliffResponse" /> class.
        /// </summary>
        public VideoXliffResponse()
        {
        }
    }
}