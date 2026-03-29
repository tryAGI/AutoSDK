//HintName: G.Models.MedicalComprehendResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MedicalComprehendResponse
    {
        /// <summary>
        /// An array of medical entities extracted from the input text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MedicalComprehendEntity> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// An array of medical entities extracted from the input text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MedicalComprehendResponse(
            global::System.Collections.Generic.IList<global::G.MedicalComprehendEntity> entities)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendResponse" /> class.
        /// </summary>
        public MedicalComprehendResponse()
        {
        }
    }
}