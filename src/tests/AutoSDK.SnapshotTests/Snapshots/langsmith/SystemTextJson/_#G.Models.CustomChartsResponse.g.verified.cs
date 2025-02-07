//HintName: G.Models.CustomChartsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CustomChartsSection> Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsResponse" /> class.
        /// </summary>
        /// <param name="sections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsResponse(
            global::System.Collections.Generic.IList<global::G.CustomChartsSection> sections)
        {
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsResponse" /> class.
        /// </summary>
        public CustomChartsResponse()
        {
        }
    }
}