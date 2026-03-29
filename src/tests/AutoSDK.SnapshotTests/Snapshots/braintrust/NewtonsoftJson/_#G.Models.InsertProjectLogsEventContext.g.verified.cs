//HintName: G.Models.InsertProjectLogsEventContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context is additional information about the code that produced the project logs event. It is essentially the textual counterpart to `metrics`. Use the `caller_*` attributes to track the location in code which produced the project logs event
    /// </summary>
    public sealed partial class InsertProjectLogsEventContext
    {
        /// <summary>
        /// The function in code which created the project logs event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller_functionname")]
        public string? CallerFunctionname { get; set; }

        /// <summary>
        /// Name of the file in code where the project logs event was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller_filename")]
        public string? CallerFilename { get; set; }

        /// <summary>
        /// Line of code where the project logs event was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller_lineno")]
        public int? CallerLineno { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventContext" /> class.
        /// </summary>
        /// <param name="callerFunctionname">
        /// The function in code which created the project logs event
        /// </param>
        /// <param name="callerFilename">
        /// Name of the file in code where the project logs event was created
        /// </param>
        /// <param name="callerLineno">
        /// Line of code where the project logs event was created
        /// </param>
        public InsertProjectLogsEventContext(
            string? callerFunctionname,
            string? callerFilename,
            int? callerLineno)
        {
            this.CallerFunctionname = callerFunctionname;
            this.CallerFilename = callerFilename;
            this.CallerLineno = callerLineno;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventContext" /> class.
        /// </summary>
        public InsertProjectLogsEventContext()
        {
        }
    }
}