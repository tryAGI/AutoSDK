//HintName: G.Models.CartesiaGenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaGenerationConfig
    {
        /// <summary>
        /// Fine-grained speed control for sonic-3. Only available for sonic-3 model.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Fine-grained volume control for sonic-3. Only available for sonic-3 model.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Experimental model controls for sonic-3. These are subject to breaking changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::G.CartesiaGenerationConfigExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaGenerationConfig" /> class.
        /// </summary>
        /// <param name="speed">
        /// Fine-grained speed control for sonic-3. Only available for sonic-3 model.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="volume">
        /// Fine-grained volume control for sonic-3. Only available for sonic-3 model.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="experimental">
        /// Experimental model controls for sonic-3. These are subject to breaking changes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaGenerationConfig(
            double? speed,
            double? volume,
            global::G.CartesiaGenerationConfigExperimental? experimental)
        {
            this.Speed = speed;
            this.Volume = volume;
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaGenerationConfig" /> class.
        /// </summary>
        public CartesiaGenerationConfig()
        {
        }
    }
}