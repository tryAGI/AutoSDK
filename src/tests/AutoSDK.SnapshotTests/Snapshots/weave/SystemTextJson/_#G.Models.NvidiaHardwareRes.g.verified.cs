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
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.NvidiaHardwareOption> Hardware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaHardwareRes" /> class.
        /// </summary>
        /// <param name="hardware"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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