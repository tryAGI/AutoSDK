//HintName: G.Models.CodeExecutionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeExecutionResult
    {
        /// <summary>
        /// The text version of the code execution result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64 encoded PNG image output from code execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("png")]
        public string? Png { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chart")]
        public global::G.Chart? Chart { get; set; }

        /// <summary>
        /// Array of charts from a superchart
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charts")]
        public global::System.Collections.Generic.IList<global::G.Chart>? Charts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The text version of the code execution result
        /// </param>
        /// <param name="png">
        /// Base64 encoded PNG image output from code execution
        /// </param>
        /// <param name="chart"></param>
        /// <param name="charts">
        /// Array of charts from a superchart
        /// </param>
        public CodeExecutionResult(
            string? text,
            string? png,
            global::G.Chart? chart,
            global::System.Collections.Generic.IList<global::G.Chart>? charts)
        {
            this.Text = text;
            this.Png = png;
            this.Chart = chart;
            this.Charts = charts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        public CodeExecutionResult()
        {
        }
    }
}