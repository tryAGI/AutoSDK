//HintName: G.Models.PartialAgentClipPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum PartialAgentClipPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialAgentClipPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentClipPresenterType value)
        {
            return value switch
            {
                PartialAgentClipPresenterType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentClipPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => PartialAgentClipPresenterType.Clip,
                _ => null,
            };
        }
    }
}