//HintName: G.Models.ResumedSandbox.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResumedSandbox
    {
        /// <summary>
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Automatically pauses the sandbox after the timeout
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoPause")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AutoPause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumedSandbox" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </param>
        public ResumedSandbox(
            int? timeout)
        {
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumedSandbox" /> class.
        /// </summary>
        public ResumedSandbox()
        {
        }
    }
}