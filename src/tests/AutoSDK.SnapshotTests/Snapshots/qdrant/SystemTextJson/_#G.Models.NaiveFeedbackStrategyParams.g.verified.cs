//HintName: G.Models.NaiveFeedbackStrategyParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NaiveFeedbackStrategyParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("a")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float A { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float B { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float C { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategyParams" /> class.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NaiveFeedbackStrategyParams(
            float a,
            float b,
            float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategyParams" /> class.
        /// </summary>
        public NaiveFeedbackStrategyParams()
        {
        }
    }
}