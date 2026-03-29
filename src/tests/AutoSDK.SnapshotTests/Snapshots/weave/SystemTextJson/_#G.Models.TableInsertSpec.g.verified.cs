//HintName: G.Models.TableInsertSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableInsertSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TableInsertSpecPayload Insert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpec" /> class.
        /// </summary>
        /// <param name="insert"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableInsertSpec(
            global::G.TableInsertSpecPayload insert)
        {
            this.Insert = insert ?? throw new global::System.ArgumentNullException(nameof(insert));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpec" /> class.
        /// </summary>
        public TableInsertSpec()
        {
        }
    }
}