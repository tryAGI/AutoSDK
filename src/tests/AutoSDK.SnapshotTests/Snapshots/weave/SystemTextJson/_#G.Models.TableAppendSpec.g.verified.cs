//HintName: G.Models.TableAppendSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableAppendSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("append")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TableAppendSpecPayload Append { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpec" /> class.
        /// </summary>
        /// <param name="append"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableAppendSpec(
            global::G.TableAppendSpecPayload append)
        {
            this.Append = append ?? throw new global::System.ArgumentNullException(nameof(append));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpec" /> class.
        /// </summary>
        public TableAppendSpec()
        {
        }
    }
}