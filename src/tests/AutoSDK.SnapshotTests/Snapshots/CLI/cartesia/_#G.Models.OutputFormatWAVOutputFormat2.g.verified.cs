//HintName: G.Models.OutputFormatWAVOutputFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputFormatWAVOutputFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputFormatWAVOutputFormatContainerJsonConverter))]
        public global::G.OutputFormatWAVOutputFormatContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatWAVOutputFormat2" /> class.
        /// </summary>
        /// <param name="container"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormatWAVOutputFormat2(
            global::G.OutputFormatWAVOutputFormatContainer? container)
        {
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatWAVOutputFormat2" /> class.
        /// </summary>
        public OutputFormatWAVOutputFormat2()
        {
        }
    }
}