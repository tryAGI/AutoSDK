//HintName: G.Models.EmbedResponse6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedResponse6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedResponse6" /> class.
        /// </summary>
        /// <param name="data"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EmbedResponse6(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedResponse6" /> class.
        /// </summary>
        public EmbedResponse6()
        {
        }
    }
}