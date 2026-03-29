//HintName: G.Models.Caption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Caption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Caption" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="end"></param>
        /// <param name="start"></param>
        public Caption(
            string text,
            double end,
            double start)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.End = end;
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Caption" /> class.
        /// </summary>
        public Caption()
        {
        }
    }
}