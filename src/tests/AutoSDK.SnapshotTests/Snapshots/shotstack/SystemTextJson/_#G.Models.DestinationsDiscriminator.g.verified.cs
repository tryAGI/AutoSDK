//HintName: G.Models.DestinationsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DestinationsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public string? Destinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationsDiscriminator" /> class.
        /// </summary>
        /// <param name="destinations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DestinationsDiscriminator(
            string? destinations)
        {
            this.Destinations = destinations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationsDiscriminator" /> class.
        /// </summary>
        public DestinationsDiscriminator()
        {
        }
    }
}