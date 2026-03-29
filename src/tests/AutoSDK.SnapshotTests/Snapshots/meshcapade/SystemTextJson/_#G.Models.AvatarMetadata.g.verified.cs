//HintName: G.Models.AvatarMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodyShape")]
        public global::G.BodyShape? BodyShape { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarMetadata" /> class.
        /// </summary>
        /// <param name="bodyShape"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvatarMetadata(
            global::G.BodyShape? bodyShape)
        {
            this.BodyShape = bodyShape;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarMetadata" /> class.
        /// </summary>
        public AvatarMetadata()
        {
        }
    }
}