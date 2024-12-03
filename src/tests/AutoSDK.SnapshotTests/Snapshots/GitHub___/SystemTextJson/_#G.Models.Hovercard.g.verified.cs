//HintName: G.Models.Hovercard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hovercard
    /// </summary>
    public sealed partial class Hovercard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.HovercardContext> Contexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hovercard" /> class.
        /// </summary>
        /// <param name="contexts"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Hovercard(
            global::System.Collections.Generic.IList<global::G.HovercardContext> contexts)
        {
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hovercard" /> class.
        /// </summary>
        public Hovercard()
        {
        }
    }
}