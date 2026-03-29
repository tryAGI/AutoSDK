//HintName: G.Models.PoseMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PoseMode
    {
        /// <summary>
        /// 
        /// </summary>
        APose,
        /// <summary>
        /// 
        /// </summary>
        TPose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PoseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PoseMode value)
        {
            return value switch
            {
                PoseMode.APose => "a-pose",
                PoseMode.TPose => "t-pose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PoseMode? ToEnum(string value)
        {
            return value switch
            {
                "a-pose" => PoseMode.APose,
                "t-pose" => PoseMode.TPose,
                _ => null,
            };
        }
    }
}