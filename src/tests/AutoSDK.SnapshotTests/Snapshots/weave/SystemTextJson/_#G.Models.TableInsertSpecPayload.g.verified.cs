//HintName: G.Models.TableInsertSpecPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableInsertSpecPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Row { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpecPayload" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="row"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableInsertSpecPayload(
            int index,
            object row)
        {
            this.Index = index;
            this.Row = row ?? throw new global::System.ArgumentNullException(nameof(row));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpecPayload" /> class.
        /// </summary>
        public TableInsertSpecPayload()
        {
        }
    }
}