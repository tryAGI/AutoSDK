//HintName: G.Models.FitToVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FitToVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockFeet")]
        public bool? LockFeet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToVideoRequest" /> class.
        /// </summary>
        /// <param name="lockFeet"></param>
        /// <param name="modelVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FitToVideoRequest(
            bool? lockFeet,
            string? modelVersion)
        {
            this.LockFeet = lockFeet;
            this.ModelVersion = modelVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToVideoRequest" /> class.
        /// </summary>
        public FitToVideoRequest()
        {
        }
    }
}