//HintName: G.Models.Pricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pricing
    {
        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hourly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Hourly { get; set; }

        /// <summary>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Input { get; set; }

        /// <summary>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Output { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Base { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Finetune { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="hourly">
        /// Example: 0
        /// </param>
        /// <param name="input">
        /// Example: 0.3
        /// </param>
        /// <param name="output">
        /// Example: 0.3
        /// </param>
        /// <param name="base">
        /// Example: 0
        /// </param>
        /// <param name="finetune">
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pricing(
            double hourly,
            double input,
            double output,
            double @base,
            double finetune)
        {
            this.Hourly = hourly;
            this.Input = input;
            this.Output = output;
            this.Base = @base;
            this.Finetune = finetune;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        public Pricing()
        {
        }
    }
}