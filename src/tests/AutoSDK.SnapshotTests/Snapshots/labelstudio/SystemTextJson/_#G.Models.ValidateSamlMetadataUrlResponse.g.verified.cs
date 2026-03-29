//HintName: G.Models.ValidateSamlMetadataUrlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateSamlMetadataUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlResponse" /> class.
        /// </summary>
        /// <param name="valid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateSamlMetadataUrlResponse(
            bool valid)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlResponse" /> class.
        /// </summary>
        public ValidateSamlMetadataUrlResponse()
        {
        }
    }
}