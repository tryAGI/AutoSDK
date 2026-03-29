//HintName: G.Models.OptimizersStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optimizers are reporting as expected
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OptimizersStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ok")]
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptimizersStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizersStatusEnum value)
        {
            return value switch
            {
                OptimizersStatusEnum.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizersStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "ok" => OptimizersStatusEnum.Ok,
                _ => null,
            };
        }
    }
}