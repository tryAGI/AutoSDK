//HintName: G.Models.TableAppendSpecPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableAppendSpecPayload
    {
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
        /// Initializes a new instance of the <see cref="TableAppendSpecPayload" /> class.
        /// </summary>
        /// <param name="row"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableAppendSpecPayload(
            object row)
        {
            this.Row = row ?? throw new global::System.ArgumentNullException(nameof(row));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpecPayload" /> class.
        /// </summary>
        public TableAppendSpecPayload()
        {
        }
    }
}