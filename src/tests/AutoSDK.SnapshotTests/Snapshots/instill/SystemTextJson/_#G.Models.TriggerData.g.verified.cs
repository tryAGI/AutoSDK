//HintName: G.Models.TriggerData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        public object? Variable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerData" /> class.
        /// </summary>
        /// <param name="variable"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerData(
            object? variable,
            global::System.Collections.Generic.Dictionary<string, string>? secret)
        {
            this.Variable = variable;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerData" /> class.
        /// </summary>
        public TriggerData()
        {
        }
    }
}