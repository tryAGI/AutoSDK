//HintName: G.Models.CreateSpansBulk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansBulk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Span> Spans { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        /// <param name="spans"></param>
        public CreateSpansBulk(
            global::System.Collections.Generic.IList<global::G.Span> spans)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        public CreateSpansBulk()
        {
        }
    }
}