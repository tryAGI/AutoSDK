//HintName: G.Models.GetConfigResponseDataConfigRetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigResponseDataConfigRetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public int? Attempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_status_codes")]
        public global::System.Collections.Generic.IList<int>? OnStatusCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigRetry" /> class.
        /// </summary>
        /// <param name="attempts"></param>
        /// <param name="onStatusCodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigResponseDataConfigRetry(
            int? attempts,
            global::System.Collections.Generic.IList<int>? onStatusCodes)
        {
            this.Attempts = attempts;
            this.OnStatusCodes = onStatusCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigResponseDataConfigRetry" /> class.
        /// </summary>
        public GetConfigResponseDataConfigRetry()
        {
        }
    }
}