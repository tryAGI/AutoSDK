//HintName: G.Models.CreateTtsResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTtsResponseItem
    {
        /// <summary>
        /// error field
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loc", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Loc { get; set; } = default!;

        /// <summary>
        /// error type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg", Required = global::Newtonsoft.Json.Required.Always)]
        public string Msg { get; set; } = default!;

        /// <summary>
        /// error context
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ctx")]
        public string? Ctx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTtsResponseItemInJsonConverter))]
        public global::G.CreateTtsResponseItemIn? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTtsResponseItem" /> class.
        /// </summary>
        /// <param name="loc">
        /// error field
        /// </param>
        /// <param name="type">
        /// error type
        /// </param>
        /// <param name="msg">
        /// error message
        /// </param>
        /// <param name="ctx">
        /// error context
        /// </param>
        /// <param name="in"></param>
        public CreateTtsResponseItem(
            global::System.Collections.Generic.IList<string> loc,
            string type,
            string msg,
            string? ctx,
            global::G.CreateTtsResponseItemIn? @in)
        {
            this.Loc = loc ?? throw new global::System.ArgumentNullException(nameof(loc));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
            this.Ctx = ctx;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTtsResponseItem" /> class.
        /// </summary>
        public CreateTtsResponseItem()
        {
        }
    }
}