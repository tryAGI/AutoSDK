//HintName: G.Models.JWTParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JWTParameters
    {
        /// <summary>
        /// JWKS URI of the JWT token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwksUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUri { get; set; }

        /// <summary>
        /// Header key to check for the JWT token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeaderKey { get; set; }

        /// <summary>
        /// Cache max age in seconds<br/>
        /// Default Value: 86400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheMaxAge")]
        public double? CacheMaxAge { get; set; }

        /// <summary>
        /// Clock tolerance in seconds<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clockTolerance")]
        public double? ClockTolerance { get; set; }

        /// <summary>
        /// Max token age<br/>
        /// Default Value: 1d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokenAge")]
        public string? MaxTokenAge { get; set; }

        /// <summary>
        /// Algorithms to check for the JWT token<br/>
        /// Default Value: [RS256]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithms")]
        public global::System.Collections.Generic.IList<string>? Algorithms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JWTParameters" /> class.
        /// </summary>
        /// <param name="jwksUri">
        /// JWKS URI of the JWT token
        /// </param>
        /// <param name="headerKey">
        /// Header key to check for the JWT token
        /// </param>
        /// <param name="cacheMaxAge">
        /// Cache max age in seconds<br/>
        /// Default Value: 86400
        /// </param>
        /// <param name="clockTolerance">
        /// Clock tolerance in seconds<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="maxTokenAge">
        /// Max token age<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="algorithms">
        /// Algorithms to check for the JWT token<br/>
        /// Default Value: [RS256]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JWTParameters(
            string jwksUri,
            string headerKey,
            double? cacheMaxAge,
            double? clockTolerance,
            string? maxTokenAge,
            global::System.Collections.Generic.IList<string>? algorithms)
        {
            this.JwksUri = jwksUri ?? throw new global::System.ArgumentNullException(nameof(jwksUri));
            this.HeaderKey = headerKey ?? throw new global::System.ArgumentNullException(nameof(headerKey));
            this.CacheMaxAge = cacheMaxAge;
            this.ClockTolerance = clockTolerance;
            this.MaxTokenAge = maxTokenAge;
            this.Algorithms = algorithms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JWTParameters" /> class.
        /// </summary>
        public JWTParameters()
        {
        }
    }
}