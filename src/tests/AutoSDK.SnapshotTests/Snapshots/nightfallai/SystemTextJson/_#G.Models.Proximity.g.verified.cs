//HintName: G.Models.Proximity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Proximity
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowBefore")]
        public int? WindowBefore { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowAfter")]
        public int? WindowAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Proximity" /> class.
        /// </summary>
        /// <param name="windowBefore">
        /// Default Value: 0
        /// </param>
        /// <param name="windowAfter">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Proximity(
            int? windowBefore,
            int? windowAfter)
        {
            this.WindowBefore = windowBefore;
            this.WindowAfter = windowAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proximity" /> class.
        /// </summary>
        public Proximity()
        {
        }
    }
}