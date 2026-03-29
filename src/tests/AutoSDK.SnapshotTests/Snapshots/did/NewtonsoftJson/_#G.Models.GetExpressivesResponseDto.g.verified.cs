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
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expressives", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetExpressivesResponseDtoExpressive> Expressives { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressivesResponseDto" /> class.
        /// </summary>
        /// <param name="expressives"></param>
        /// <param name="token">
        /// The pagination token for the next page of expressives
        /// </param>
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