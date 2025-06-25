//HintName: G.Models.BetaModelInfoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Models, this is always `"model"`.<br/>
    /// Default Value: model
    /// </summary>
    public enum BetaModelInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelInfoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelInfoType value)
        {
            return value switch
            {
                BetaModelInfoType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelInfoType? ToEnum(string value)
        {
            return value switch
            {
                "model" => BetaModelInfoType.Model,
                _ => null,
            };
        }
    }
}