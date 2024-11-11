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
        [global::Newtonsoft.Json.JsonProperty("sections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomChartsSection> Sections { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsResponse" /> class.
        /// </summary>
        /// <param name="sections"></param>
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