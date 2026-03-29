//HintName: G.Models.CreateDubbingProjectApiResponseFail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingProjectApiResponseFail
    {
        /// <summary>
        /// Errors related to the creation of the dubbed videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbedErrors")]
        public global::System.Collections.Generic.IList<global::G.DubbedVideosApiError>? DubbedErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiResponseFail" /> class.
        /// </summary>
        /// <param name="dubbedErrors">
        /// Errors related to the creation of the dubbed videos.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDubbingProjectApiResponseFail(
            global::System.Collections.Generic.IList<global::G.DubbedVideosApiError>? dubbedErrors)
        {
            this.DubbedErrors = dubbedErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiResponseFail" /> class.
        /// </summary>
        public CreateDubbingProjectApiResponseFail()
        {
        }
    }
}