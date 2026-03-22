//HintName: G.Models.FTClassifierLossFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FTClassifierLossFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi_class")]
        MultiClass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="single_class")]
        SingleClass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FTClassifierLossFunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FTClassifierLossFunction value)
        {
            return value switch
            {
                FTClassifierLossFunction.MultiClass => "multi_class",
                FTClassifierLossFunction.SingleClass => "single_class",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FTClassifierLossFunction? ToEnum(string value)
        {
            return value switch
            {
                "multi_class" => FTClassifierLossFunction.MultiClass,
                "single_class" => FTClassifierLossFunction.SingleClass,
                _ => null,
            };
        }
    }
}