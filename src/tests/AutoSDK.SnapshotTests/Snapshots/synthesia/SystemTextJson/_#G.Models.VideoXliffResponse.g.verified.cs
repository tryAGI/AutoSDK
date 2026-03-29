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
        [global::System.Text.Json.Serialization.JsonPropertyName("xliff")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Xliff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoXliffResponse" /> class.
        /// </summary>
        /// <param name="xliff"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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