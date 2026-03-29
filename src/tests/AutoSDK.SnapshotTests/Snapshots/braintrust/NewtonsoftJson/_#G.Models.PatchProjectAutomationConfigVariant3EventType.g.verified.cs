//HintName: G.Models.PatchProjectAutomationConfigVariant3EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchProjectAutomationConfigVariant3EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retention")]
        Retention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant3EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant3EventType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant3EventType.Retention => "retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant3EventType? ToEnum(string value)
        {
            return value switch
            {
                "retention" => PatchProjectAutomationConfigVariant3EventType.Retention,
                _ => null,
            };
        }
    }
}