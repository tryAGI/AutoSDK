//HintName: G.Models.PartialTalkAgentPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum PartialTalkAgentPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialTalkAgentPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialTalkAgentPresenterType value)
        {
            return value switch
            {
                PartialTalkAgentPresenterType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialTalkAgentPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => PartialTalkAgentPresenterType.Talk,
                _ => null,
            };
        }
    }
}