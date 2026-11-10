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
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_io_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PayloadIoRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_io_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PayloadIoWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_index_io_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PayloadIndexIoRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_index_io_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PayloadIndexIoWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_io_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long VectorIoRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_io_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long VectorIoWrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareUsage(
            long cpu,
            long payloadIoRead,
            long payloadIoWrite,
            long payloadIndexIoRead,
            long payloadIndexIoWrite,
            long vectorIoRead,
            long vectorIoWrite)
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