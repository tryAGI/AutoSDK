//HintName: G.Models.CreateClipTrainRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the clip training
    /// </summary>
    public sealed partial class CreateClipTrainRequestConfig
    {
        /// <summary>
        /// Whether the clip is a greenscreen clip<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipTrainRequestConfig" /> class.
        /// </summary>
        /// <param name="isGreenscreen">
        /// Whether the clip is a greenscreen clip<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipTrainRequestConfig(
            bool? isGreenscreen)
        {
            this.IsGreenscreen = isGreenscreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipTrainRequestConfig" /> class.
        /// </summary>
        public CreateClipTrainRequestConfig()
        {
        }
    }
}