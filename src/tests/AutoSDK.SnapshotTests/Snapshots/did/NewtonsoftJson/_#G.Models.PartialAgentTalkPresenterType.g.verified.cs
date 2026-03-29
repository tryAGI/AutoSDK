//HintName: G.Models.PartialAgentTalkPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentTalkPresenterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk")]
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialAgentTalkPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentTalkPresenterType value)
        {
            return value switch
            {
                PartialAgentTalkPresenterType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentTalkPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => PartialAgentTalkPresenterType.Talk,
                _ => null,
            };
        }
    }
}