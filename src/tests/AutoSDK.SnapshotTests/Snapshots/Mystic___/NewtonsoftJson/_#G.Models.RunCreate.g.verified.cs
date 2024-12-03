//HintName: G.Models.RunCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RunCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pipeline { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunInput> Inputs { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("async_run")]
        public bool? AsyncRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_for_resources")]
        public bool? WaitForResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCreate" /> class.
        /// </summary>
        /// <param name="pipeline"></param>
        /// <param name="inputs"></param>
        /// <param name="asyncRun">
        /// Default Value: false
        /// </param>
        /// <param name="waitForResources"></param>
        /// <param name="runId"></param>
        public RunCreate(
            string pipeline,
            global::System.Collections.Generic.IList<global::G.RunInput> inputs,
            bool? asyncRun,
            bool? waitForResources,
            string? runId)
        {
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.AsyncRun = asyncRun;
            this.WaitForResources = waitForResources;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCreate" /> class.
        /// </summary>
        public RunCreate()
        {
        }
    }
}