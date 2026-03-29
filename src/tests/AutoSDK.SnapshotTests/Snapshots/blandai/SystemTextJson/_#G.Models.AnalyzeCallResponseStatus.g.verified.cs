//HintName: G.Models.AnalyzeCallResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyzeCallResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeCallResponseStatus value)
        {
            return value switch
            {
                AnalyzeCallResponseStatus.Error => "error",
                AnalyzeCallResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AnalyzeCallResponseStatus.Error,
                "success" => AnalyzeCallResponseStatus.Success,
                _ => null,
            };
        }
    }
}