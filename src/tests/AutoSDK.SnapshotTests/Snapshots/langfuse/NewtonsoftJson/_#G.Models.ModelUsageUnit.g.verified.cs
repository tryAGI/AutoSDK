//HintName: G.Models.ModelUsageUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unit of usage in Langfuse
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelUsageUnit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHARACTERS")]
        Characters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IMAGES")]
        Images,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MILLISECONDS")]
        Milliseconds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REQUESTS")]
        Requests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SECONDS")]
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOKENS")]
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelUsageUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelUsageUnit value)
        {
            return value switch
            {
                ModelUsageUnit.Characters => "CHARACTERS",
                ModelUsageUnit.Images => "IMAGES",
                ModelUsageUnit.Milliseconds => "MILLISECONDS",
                ModelUsageUnit.Requests => "REQUESTS",
                ModelUsageUnit.Seconds => "SECONDS",
                ModelUsageUnit.Tokens => "TOKENS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelUsageUnit? ToEnum(string value)
        {
            return value switch
            {
                "CHARACTERS" => ModelUsageUnit.Characters,
                "IMAGES" => ModelUsageUnit.Images,
                "MILLISECONDS" => ModelUsageUnit.Milliseconds,
                "REQUESTS" => ModelUsageUnit.Requests,
                "SECONDS" => ModelUsageUnit.Seconds,
                "TOKENS" => ModelUsageUnit.Tokens,
                _ => null,
            };
        }
    }
}