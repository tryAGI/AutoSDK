//HintName: G.Models.ShotstackTextGeneratorOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-generator` for text generation.<br/>
    /// Default Value: text-generator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShotstackTextGeneratorOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-generator")]
        TextGenerator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackTextGeneratorOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackTextGeneratorOptionsType value)
        {
            return value switch
            {
                ShotstackTextGeneratorOptionsType.TextGenerator => "text-generator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackTextGeneratorOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-generator" => ShotstackTextGeneratorOptionsType.TextGenerator,
                _ => null,
            };
        }
    }
}