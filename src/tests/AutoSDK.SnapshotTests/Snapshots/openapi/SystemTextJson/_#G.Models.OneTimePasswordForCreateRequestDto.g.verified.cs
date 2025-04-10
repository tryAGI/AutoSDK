//HintName: G.Models.OneTimePasswordForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OneTimePasswordForCreateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isXtera")]
        public bool? IsXtera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimePasswordForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isXtera"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OneTimePasswordForCreateRequestDto(
            long? userId,
            bool? isXtera)
        {
            this.UserId = userId;
            this.IsXtera = isXtera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimePasswordForCreateRequestDto" /> class.
        /// </summary>
        public OneTimePasswordForCreateRequestDto()
        {
        }
    }
}