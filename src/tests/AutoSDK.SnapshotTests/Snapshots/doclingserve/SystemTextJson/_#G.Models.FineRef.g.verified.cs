//HintName: G.Models.FineRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fine-granular reference item that can capture span range info.
    /// </summary>
    public sealed partial class FineRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public byte[]? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineRef" /> class.
        /// </summary>
        /// <param name="x_ref"></param>
        /// <param name="range"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineRef(
            string x_ref,
            byte[]? range)
        {
            this.x_ref = x_ref ?? throw new global::System.ArgumentNullException(nameof(x_ref));
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineRef" /> class.
        /// </summary>
        public FineRef()
        {
        }
    }
}