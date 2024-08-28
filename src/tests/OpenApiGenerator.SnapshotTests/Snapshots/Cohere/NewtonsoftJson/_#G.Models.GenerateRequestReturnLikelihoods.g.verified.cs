//HintName: G.Models.GenerateRequestReturnLikelihoods.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `GENERATION|ALL|NONE` to specify how and if the token likelihoods are returned with the response. Defaults to `NONE`.<br/>
    /// If `GENERATION` is selected, the token likelihoods will only be provided for generated text.<br/>
    /// If `ALL` is selected, the token likelihoods will be provided both for the prompt and the generated text.<br/>
    /// Default Value: NONE
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateRequestReturnLikelihoods
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERATION")]
        GENERATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        ALL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRequestReturnLikelihoodsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRequestReturnLikelihoods value)
        {
            return value switch
            {
                GenerateRequestReturnLikelihoods.GENERATION => "GENERATION",
                GenerateRequestReturnLikelihoods.ALL => "ALL",
                GenerateRequestReturnLikelihoods.NONE => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRequestReturnLikelihoods? ToEnum(string value)
        {
            return value switch
            {
                "GENERATION" => GenerateRequestReturnLikelihoods.GENERATION,
                "ALL" => GenerateRequestReturnLikelihoods.ALL,
                "NONE" => GenerateRequestReturnLikelihoods.NONE,
                _ => null,
            };
        }
    }
}