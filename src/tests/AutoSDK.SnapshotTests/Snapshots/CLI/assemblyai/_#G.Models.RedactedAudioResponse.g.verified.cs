//HintName: G.Models.RedactedAudioResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"redacted_audio_url":"https://s3.us-west-2.amazonaws.com/api.assembly.ai.usw2/redacted-audio/785efd9e-0e20-45e1-967b-3db17770ed9f.wav?AWSAccessKeyId=ASIAVASQFLPGLUP5JD7Y\u0026Signature=z1r2MOA46esiiAmk%2FreBkL8rl6g%3D\u0026x-amz-security-token=IQoJb3JpZ2luX2VjEPv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLXdlc3QtMiJHMEUCIHxKoUJdd5P%2Fdy4WlfvRNppQtauTy7OuAb5azR2OIoYSAiEA8iPx4xAx0pbZztT4e7fGnzPS4phvNCnYKflIijUoxDsq%2BwMIMxAEGgwzNDQ4MzkyNDg4NDQiDJxsCgo0cDg789FV0CrYAwPK3CHbRHoNPFiQ%2FO6EdHZ4OSFRcS%2FDvDyHQRNnYNSwG4JB2mUMWEVw808JWTya%2But4wEcmPiUCVJMTvh70cxhILAxP84CBTuWGM%2Fszbj4tn1thjVsqovf9YZmP17OCFa77Bc9%2F9RwtRaABEqJ2eb6%2Bsir7w0MMzhe1z%2F%2B1PUKxicJAZasBv3Ova%2BTY2eNkPZHQ4Njie4X5sh05b%2BrKnz58E7GTQ1sHZQDYHZecwb5fP0B3LR0vuqNtK%2BdpMAxw5H7BinQ4rdccLmsLLMQeVn8jdRDZNEvsdmoeQL0y0qD%2BUcyGMJoAjMT4FnXhBhVxc3bgkVUbHlZMn48FNCYcmzM8UB9wGmSnr6iQoqEaFElfQVbvAzsW7lnlfLROZxMvGXyliobPYPSaYZlVYgHcIxeWuOAXRtEtmL2jbaX4ghCVgJBVO3BBzTgub2jB0KPU6lYZLLM4kf%2B8hKX8iyxSRc6ZVEefTcyruoDppjB028pA9q75hLH1CZwhfLoM%2F3z5f0aFCl05zQnaa10nbcKj0hERELf4FXqS8yWbSutlRcd7Rr9o8jN31QGUscpsuIvl%2FpyJcZmItX8nO%2FF0s1QjrIi11DLYD9YoOh7eVkN8eKKn5w4cHldVI2sw4NCPqgY6pQE%2BM9va2ad1%2BNrXeQ9t8K41lojTN0BFmM8ERD5fF77xcTlW8VdV%2FiJeLLHDvnYYWVKcga9hSROlmsqvMyn3Tmhz7KQbIepSAOKhcHM%2FyUaLfErvCtjXGwo8nsKForL7SKiGkaRCBmwfQtkSVP6m4tGT50YdGxakh54f8uyC55SbkElknRbpl5haiZ%2F82UddFBkdPcM3t0s7vwbEy%2BbilYyetOr6htc%3D\u0026Expires=1698966551","status":"redacted_audio_ready"}
    /// </summary>
    public sealed partial class RedactedAudioResponse
    {
        /// <summary>
        /// The status of the redacted audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RedactedAudioStatusJsonConverter))]
        public global::G.RedactedAudioStatus Status { get; set; }

        /// <summary>
        /// The URL of the redacted audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the redacted audio
        /// </param>
        /// <param name="redactedAudioUrl">
        /// The URL of the redacted audio file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactedAudioResponse(
            string redactedAudioUrl,
            global::G.RedactedAudioStatus status)
        {
            this.RedactedAudioUrl = redactedAudioUrl ?? throw new global::System.ArgumentNullException(nameof(redactedAudioUrl));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        public RedactedAudioResponse()
        {
        }
    }
}