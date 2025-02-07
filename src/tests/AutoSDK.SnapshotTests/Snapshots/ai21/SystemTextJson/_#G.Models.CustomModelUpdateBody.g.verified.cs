//HintName: G.Models.CustomModelUpdateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomModelUpdateBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultEpoch")]
        public int? DefaultEpoch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelUpdateBody" /> class.
        /// </summary>
        /// <param name="defaultEpoch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomModelUpdateBody(
            int? defaultEpoch)
        {
            this.DefaultEpoch = defaultEpoch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelUpdateBody" /> class.
        /// </summary>
        public CustomModelUpdateBody()
        {
        }
    }
}