//HintName: G.Models.PartialClipAgentPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialClipAgentPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialClipAgentPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialClipAgentPresenterType value)
        {
            return value switch
            {
                PartialClipAgentPresenterType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialClipAgentPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => PartialClipAgentPresenterType.Clip,
                _ => null,
            };
        }
    }
}