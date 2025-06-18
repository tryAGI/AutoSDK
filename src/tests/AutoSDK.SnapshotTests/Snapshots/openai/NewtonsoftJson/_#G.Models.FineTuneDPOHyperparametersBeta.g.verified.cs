﻿//HintName: G.Models.FineTuneDPOHyperparametersBeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneDPOHyperparametersBeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneDPOHyperparametersBetaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneDPOHyperparametersBeta value)
        {
            return value switch
            {
                FineTuneDPOHyperparametersBeta.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneDPOHyperparametersBeta? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneDPOHyperparametersBeta.Auto,
                _ => null,
            };
        }
    }
}