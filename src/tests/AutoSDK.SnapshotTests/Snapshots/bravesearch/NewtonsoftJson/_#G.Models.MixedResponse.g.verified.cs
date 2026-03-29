//HintName: G.Models.MixedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about how results are mixed/ranked.
    /// </summary>
    public sealed partial class MixedResponse
    {
        /// <summary>
        /// The type identifier (always "mixed").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Main result order, each entry references a result type and index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("main")]
        public global::System.Collections.Generic.IList<global::G.ResultReference>? Main { get; set; }

        /// <summary>
        /// Results placed at the top.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public global::System.Collections.Generic.IList<global::G.ResultReference>? Top { get; set; }

        /// <summary>
        /// Results placed on the side.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side")]
        public global::System.Collections.Generic.IList<global::G.ResultReference>? Side { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MixedResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier (always "mixed").
        /// </param>
        /// <param name="main">
        /// Main result order, each entry references a result type and index.
        /// </param>
        /// <param name="top">
        /// Results placed at the top.
        /// </param>
        /// <param name="side">
        /// Results placed on the side.
        /// </param>
        public MixedResponse(
            string? type,
            global::System.Collections.Generic.IList<global::G.ResultReference>? main,
            global::System.Collections.Generic.IList<global::G.ResultReference>? top,
            global::System.Collections.Generic.IList<global::G.ResultReference>? side)
        {
            this.Type = type;
            this.Main = main;
            this.Top = top;
            this.Side = side;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MixedResponse" /> class.
        /// </summary>
        public MixedResponse()
        {
        }
    }
}