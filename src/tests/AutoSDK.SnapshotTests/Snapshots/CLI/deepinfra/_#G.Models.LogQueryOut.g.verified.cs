//HintName: G.Models.LogQueryOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogQueryOut
    {
        /// <summary>
        /// list of log lines ordered by increasing timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogQueryOut" /> class.
        /// </summary>
        /// <param name="entries">
        /// list of log lines ordered by increasing timestamp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogQueryOut(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogQueryOut" /> class.
        /// </summary>
        public LogQueryOut()
        {
        }
    }
}