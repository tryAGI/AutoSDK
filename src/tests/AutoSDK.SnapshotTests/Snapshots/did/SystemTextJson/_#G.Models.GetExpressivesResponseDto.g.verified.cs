//HintName: G.Models.GetExpressivesResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressivesResponseDto
    {
        /// <summary>
        /// The pagination token for the next page of expressives
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressives")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetExpressivesResponseDtoExpressive> Expressives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressivesResponseDto" /> class.
        /// </summary>
        /// <param name="expressives"></param>
        /// <param name="token">
        /// The pagination token for the next page of expressives
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExpressivesResponseDto(
            global::System.Collections.Generic.IList<global::G.GetExpressivesResponseDtoExpressive> expressives,
            string? token)
        {
            this.Token = token;
            this.Expressives = expressives ?? throw new global::System.ArgumentNullException(nameof(expressives));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressivesResponseDto" /> class.
        /// </summary>
        public GetExpressivesResponseDto()
        {
        }
    }
}