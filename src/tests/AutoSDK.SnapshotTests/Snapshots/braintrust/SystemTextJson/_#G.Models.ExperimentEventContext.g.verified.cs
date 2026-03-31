//HintName: G.Models.ExperimentEventContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context is additional information about the code that produced the experiment event. It is essentially the textual counterpart to `metrics`. Use the `caller_*` attributes to track the location in code which produced the experiment event
    /// </summary>
    public sealed partial class ExperimentEventContext
    {
        /// <summary>
        /// The function in code which created the experiment event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_functionname")]
        public string? CallerFunctionname { get; set; }

        /// <summary>
        /// Name of the file in code where the experiment event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_filename")]
        public string? CallerFilename { get; set; }

        /// <summary>
        /// Line of code where the experiment event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_lineno")]
        public int? CallerLineno { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEventContext" /> class.
        /// </summary>
        /// <param name="callerFunctionname">
        /// The function in code which created the experiment event
        /// </param>
        /// <param name="callerFilename">
        /// Name of the file in code where the experiment event was created
        /// </param>
        /// <param name="callerLineno">
        /// Line of code where the experiment event was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentEventContext(
            string? callerFunctionname,
            string? callerFilename,
            int? callerLineno)
        {
            this.CallerFunctionname = callerFunctionname;
            this.CallerFilename = callerFilename;
            this.CallerLineno = callerLineno;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEventContext" /> class.
        /// </summary>
        public ExperimentEventContext()
        {
        }
    }
}