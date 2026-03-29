//HintName: G.Models.SDKLogBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SDKLogBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Log { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SDKLogBody" /> class.
        /// </summary>
        /// <param name="log"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SDKLogBody(
            object log)
        {
            this.Log = log ?? throw new global::System.ArgumentNullException(nameof(log));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SDKLogBody" /> class.
        /// </summary>
        public SDKLogBody()
        {
        }
    }
}