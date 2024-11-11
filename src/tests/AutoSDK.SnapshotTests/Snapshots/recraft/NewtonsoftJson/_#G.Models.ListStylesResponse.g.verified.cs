//HintName: G.Models.ListStylesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListStylesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("styles", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Style> Styles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStylesResponse" /> class.
        /// </summary>
        /// <param name="styles"></param>
        public ListStylesResponse(
            global::System.Collections.Generic.IList<global::G.Style> styles)
        {
            this.Styles = styles ?? throw new global::System.ArgumentNullException(nameof(styles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStylesResponse" /> class.
        /// </summary>
        public ListStylesResponse()
        {
        }
    }
}