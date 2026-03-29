//HintName: G.Models.NvidiaHardwareRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NvidiaHardwareRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.NvidiaHardwareOption> Hardware { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaHardwareRes" /> class.
        /// </summary>
        /// <param name="hardware"></param>
        public NvidiaHardwareRes(
            global::System.Collections.Generic.IList<global::G.NvidiaHardwareOption> hardware)
        {
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaHardwareRes" /> class.
        /// </summary>
        public NvidiaHardwareRes()
        {
        }
    }
}