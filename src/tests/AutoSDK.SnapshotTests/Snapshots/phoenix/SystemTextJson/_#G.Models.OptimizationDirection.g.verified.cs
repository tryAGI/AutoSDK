//HintName: G.Models.OptimizationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Maximize,
        /// <summary>
        /// 
        /// </summary>
        Minimize,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptimizationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizationDirection value)
        {
            return value switch
            {
                OptimizationDirection.Maximize => "MAXIMIZE",
                OptimizationDirection.Minimize => "MINIMIZE",
                OptimizationDirection.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizationDirection? ToEnum(string value)
        {
            return value switch
            {
                "MAXIMIZE" => OptimizationDirection.Maximize,
                "MINIMIZE" => OptimizationDirection.Minimize,
                "NONE" => OptimizationDirection.None,
                _ => null,
            };
        }
    }
}