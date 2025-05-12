//HintName: G.Models.SingleCustomChartSubSectionResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleCustomChartSubSectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Guid?, string> Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SingleCustomChartResponse> Charts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartSubSectionResponse" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="charts"></param>
        public SingleCustomChartSubSectionResponse(
            string title,
            int index,
            global::G.AnyOf<global::System.Guid?, string> id,
            global::System.Collections.Generic.IList<global::G.SingleCustomChartResponse> charts,
            string? description)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Index = index;
            this.Id = id;
            this.Charts = charts ?? throw new global::System.ArgumentNullException(nameof(charts));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartSubSectionResponse" /> class.
        /// </summary>
        public SingleCustomChartSubSectionResponse()
        {
        }
    }
}