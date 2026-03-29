//HintName: G.Models.ViewOptionsTableViewOptionsChartAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsTableViewOptionsChartAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsChartAnnotation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        public ViewOptionsTableViewOptionsChartAnnotation(
            string id,
            string text)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsChartAnnotation" /> class.
        /// </summary>
        public ViewOptionsTableViewOptionsChartAnnotation()
        {
        }
    }
}