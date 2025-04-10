//HintName: G.Models.UserForBlockRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForBlockRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public bool? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockRemarks")]
        public string? BlockRemarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForBlockRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="block"></param>
        /// <param name="blockRemarks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForBlockRequestDto(
            long? id,
            bool? block,
            string? blockRemarks)
        {
            this.Id = id;
            this.Block = block;
            this.BlockRemarks = blockRemarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForBlockRequestDto" /> class.
        /// </summary>
        public UserForBlockRequestDto()
        {
        }
    }
}