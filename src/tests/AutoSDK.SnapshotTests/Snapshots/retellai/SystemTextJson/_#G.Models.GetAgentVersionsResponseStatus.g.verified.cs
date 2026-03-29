//HintName: G.Models.GetAgentVersionsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentVersionsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentVersionsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentVersionsResponseStatus value)
        {
            return value switch
            {
                GetAgentVersionsResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentVersionsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentVersionsResponseStatus.Error,
                _ => null,
            };
        }
    }
}