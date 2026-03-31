//HintName: G.Models.ClipAgentPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum ClipAgentPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipAgentPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAgentPresenterType value)
        {
            return value switch
            {
                ClipAgentPresenterType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAgentPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => ClipAgentPresenterType.Clip,
                _ => null,
            };
        }
    }
}