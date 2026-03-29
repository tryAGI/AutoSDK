//HintName: G.Models.HardwareUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage of the hardware resources, spent to process the request
    /// </summary>
    public sealed partial class HardwareUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpu", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cpu { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_io_read", Required = global::Newtonsoft.Json.Required.Always)]
        public int PayloadIoRead { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_io_write", Required = global::Newtonsoft.Json.Required.Always)]
        public int PayloadIoWrite { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_index_io_read", Required = global::Newtonsoft.Json.Required.Always)]
        public int PayloadIndexIoRead { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_index_io_write", Required = global::Newtonsoft.Json.Required.Always)]
        public int PayloadIndexIoWrite { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_io_read", Required = global::Newtonsoft.Json.Required.Always)]
        public int VectorIoRead { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_io_write", Required = global::Newtonsoft.Json.Required.Always)]
        public int VectorIoWrite { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareUsage" /> class.
        /// </summary>
        /// <param name="cpu"></param>
        /// <param name="payloadIoRead"></param>
        /// <param name="payloadIoWrite"></param>
        /// <param name="payloadIndexIoRead"></param>
        /// <param name="payloadIndexIoWrite"></param>
        /// <param name="vectorIoRead"></param>
        /// <param name="vectorIoWrite"></param>
        public HardwareUsage(
            int cpu,
            int payloadIoRead,
            int payloadIoWrite,
            int payloadIndexIoRead,
            int payloadIndexIoWrite,
            int vectorIoRead,
            int vectorIoWrite)
        {
            this.Cpu = cpu;
            this.PayloadIoRead = payloadIoRead;
            this.PayloadIoWrite = payloadIoWrite;
            this.PayloadIndexIoRead = payloadIndexIoRead;
            this.PayloadIndexIoWrite = payloadIndexIoWrite;
            this.VectorIoRead = vectorIoRead;
            this.VectorIoWrite = vectorIoWrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareUsage" /> class.
        /// </summary>
        public HardwareUsage()
        {
        }
    }
}