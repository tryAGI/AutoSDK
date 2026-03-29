//HintName: G.Models.ComputerToolCallOutputResourceVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComputerToolCallOutputResourceVariant2
    {
        /// <summary>
        /// The unique ID of the computer call tool output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutputResourceVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the computer call tool output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolCallOutputResourceVariant2(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutputResourceVariant2" /> class.
        /// </summary>
        public ComputerToolCallOutputResourceVariant2()
        {
        }
    }
}